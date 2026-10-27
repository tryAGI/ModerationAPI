#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

if [[ -n "${AUTOSDK_EXECUTABLE:-}" ]]; then
  autosdk() { "$AUTOSDK_EXECUTABLE" "$@"; }
else
  install_autosdk_cli
fi

rm -rf Generated
spec_tmp="$(mktemp)"
trap 'rm -f "$spec_tmp"' EXIT
fetch_spec --fail --silent --show-error -L -o "$spec_tmp" https://api.moderationapi.com/v1/openapi.json
# Provider documentation renamed operation IDs and groups. Preserve existing C#
# names without changing paths, request/response schemas or newly added operations.
jq --slurpfile overrides operation-id-overrides.json '
  reduce $overrides[0][] as $op (.;
    if .paths[$op.path][$op.method] == null then
      error("Existing SDK operation disappeared from the provider schema: " + $op.method + " " + $op.path)
    else .paths[$op.path][$op.method].operationId = $op.operationId
      | .paths[$op.path][$op.method].tags = $op.tags
      | del(.paths[$op.path][$op.method]["x-speakeasy-group"], .paths[$op.path][$op.method]["x-speakeasy-name-override"])
    end)
' "$spec_tmp" > openapi.yaml
autosdk generate openapi.yaml \
  --namespace ModerationAPI \
  --clientClassName ModerationAPIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
