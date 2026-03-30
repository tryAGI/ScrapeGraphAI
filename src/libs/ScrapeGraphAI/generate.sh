dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.scrapegraphai.com/openapi.json
autosdk generate openapi.yaml \
  --namespace ScrapeGraphAI \
  --clientClassName ScrapeGraphAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:SGAI-APIKEY \
  --base-url https://api.scrapegraphai.com
