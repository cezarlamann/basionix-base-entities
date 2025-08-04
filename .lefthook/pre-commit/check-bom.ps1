$IgnoreExtensions = @(
    'csproj', 'sln', 'resx', 'xml', 'ps1',
    'jpg', 'jpeg', 'png', 'gif', 'bmp', 'ico',
    'pdf', 'zip', 'exe', 'dll', 'ttf', 'woff', 'woff2',
    'eot', 'mp4', 'mp3', 'avi', 'mov'
)

$Files = git diff --cached --name-only --diff-filter=ACM
$HasBom = $false

foreach ($file in $Files) {
    if (!(Test-Path $file)) { continue }
    $ext = [System.IO.Path]::GetExtension($file).TrimStart('.').ToLower()
    if ($IgnoreExtensions -contains $ext) { continue }

    $fs = [System.IO.File]::OpenRead($file)
    $bytes = New-Object byte[] 3
    $fs.Read($bytes, 0, 3) | Out-Null
    $fs.Close()

    if ($bytes[0] -eq 0xEF -and $bytes[1] -eq 0xBB -and $bytes[2] -eq 0xBF) {
        Write-Host "❌ File '$file' contains UTF-8 BOM. Please remove it." -ForegroundColor Red
        $HasBom = $true
    }
}

if ($HasBom) {
    Write-Host "💥 Commit aborted due to UTF-8 BOMs." -ForegroundColor Red
    exit 1
}

exit 0
