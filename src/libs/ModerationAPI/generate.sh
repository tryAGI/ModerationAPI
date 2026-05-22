#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease 2>/dev/null || dotnet tool install --global autosdk.cli --prerelease

rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.moderationapi.com/openapi.json
autosdk generate openapi.yaml \
  --namespace ModerationAPI \
  --clientClassName ModerationAPIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
