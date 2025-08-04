$DefaultMaxLength = 120
$MaxLength = $DefaultMaxLength

# Try to read max_line_length from .editorconfig
if (Test-Path ".editorconfig") {
    $lines = Get-Content .editorconfig
    foreach ($line in $lines) {
        if ($line -match '^\s*max_line_length\s*=\s*(\d+)') {
            $MaxLength = [int]$Matches[1]
            break
        }
    }
}

# Patterns to exclude
$ExcludePatterns = @(
    '\.md$', '\.csv$', '\.Designer.cs$', '\.json$', '\.xml$', '\.tsv$', '\.txt$'
    , '\.editorconfig$', '\.gitignore$', '\.csproj$', '\.gitattributes$', '\.props$'
)

$Files = git diff --cached --name-only --diff-filter=ACM
$HasLongLines = $false

foreach ($file in $Files) {
    if (!(Test-Path $file)) { continue }

    # Skip excluded files
    foreach ($pattern in $ExcludePatterns) {
        if ($file -match $pattern) { continue 2 }
    }

    # Skip binary files (basic check: non-printable chars in first few KB)
    $isBinary = [System.IO.File]::ReadAllBytes($file)[0..7999] -contains 0
    if ($isBinary) { continue }

    $lines = Get-Content $file
    for ($i = 0; $i -lt $lines.Count; $i++) {
        $line = $lines[$i]
        if ($line.Length -gt $MaxLength) {
            Write-Host "❌ $file has a line longer than $MaxLength characters (line $($i+1)):" -ForegroundColor Red
            Write-Host "→ $($line.Substring(0, [Math]::Min($line.Length, $MaxLength)))..." -ForegroundColor DarkGray
            $HasLongLines = $true
            break
        }
    }
}

if ($HasLongLines) {
    Write-Host "💥 Commit aborted due to long lines." -ForegroundColor Red
    exit 1
}

exit 0
