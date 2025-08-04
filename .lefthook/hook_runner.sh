#!/usr/bin/env bash

# Usage: ./runner.sh pre-commit/check-bom
# Get the script name from the first argument
SCRIPT_NAME="$1"

if [ -z "$SCRIPT_NAME" ]; then
  echo "Usage: $0 <script-path-without-extension>"
  echo "Example: $0 pre-commit/check-bom"
  exit 1
fi

case "$(uname -s)" in
    MINGW*|MSYS*)
        powershell.exe -File ".lefthook/${SCRIPT_NAME}.ps1"
        ;;
    *)
        bash ".lefthook/${SCRIPT_NAME}.sh"
        ;;
esac