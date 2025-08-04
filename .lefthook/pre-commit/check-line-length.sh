#!/bin/bash
# Default max line length
MAX_LENGTH=120

# Try to read max_line_length from .editorconfig if it exists
if [ -f .editorconfig ]; then
    config_value=$(awk -F '=' '/^max_line_length\s*=\s*/ { gsub(/ /, "", $2); print $2 }' .editorconfig | head -n 1)
    if [[ "$config_value" =~ ^[0-9]+$ ]]; then
        MAX_LENGTH=$config_value
    fi
fi

# List of patterns to exclude
exclude_patterns="\.md$|\.csv$|\.Designer.cs$|\.csproj$|\.props$|\.json$|\.xml$|"
exclude_patterns+="\.tsv$|\.txt$|\.editorconfig$|\.gitignore$|\.gitattributes$"

fail=0
files=$(git diff --cached --name-only --diff-filter=ACM)

for file in $files; do
    if [ ! -f "$file" ]; then continue; fi

    # Skip excluded patterns
    if echo "$file" | grep -qE "$exclude_patterns"; then continue; fi

    # Skip binary files
    if ! file "$file" | grep -q "text"; then continue; fi

    # Check each line length
    while IFS= read -r line || [ -n "$line" ]; do
        if [ ${#line} -gt $MAX_LENGTH ]; then
            echo "❌ $file has a line longer than $MAX_LENGTH characters:"
            echo "→ ${line:0:$MAX_LENGTH}..."
            fail=1
            break
        fi
    done < "$file"
done

if [ $fail -eq 1 ]; then
    echo "💥 Commit aborted due to long lines."
    exit 1
fi

exit 0
