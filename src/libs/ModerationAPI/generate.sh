dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.moderationapi.com/openapi.json
autosdk generate openapi.yaml \
  --namespace ModerationAPI \
  --clientClassName ModerationAPIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
