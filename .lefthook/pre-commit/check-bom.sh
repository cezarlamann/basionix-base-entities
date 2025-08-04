#!/bin/bash
ignore_extensions="csproj|sln|resx|xml|ps1|jpg|jpeg|png|gif|bmp|ico|pdf|zip|exe|dll|ttf|woff|woff2|eot|mp4|mp3|avi|mov"
fail=0

files=$(git diff --cached --name-only --diff-filter=ACM)

for file in $files; do
    if [ ! -f "$file" ]; then continue; fi
    ext="${file##*.}"
    if echo "$ext" | grep -iEq "^($ignore_extensions)$"; then
        continue
    fi

    if file "$file" | grep -q "text"; then
        if head -c 3 "$file" | grep -q $'\xEF\xBB\xBF'; then
            echo "❌ File '$file' contains UTF-8 BOM. Please remove it."
            fail=1
        fi
    fi
done

if [ $fail -eq 1 ]; then
    echo "💥 Commit aborted due to UTF-8 BOMs."
    exit 1
fi

exit 0
