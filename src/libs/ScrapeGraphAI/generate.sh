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

install_autosdk_cli
rm -rf Generated
fetch_spec -o openapi.yaml https://api.scrapegraphai.com/openapi.json
autosdk generate openapi.yaml \
  --namespace ScrapeGraphAI \
  --clientClassName ScrapeGraphAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:SGAI-APIKEY \
  --base-url https://api.scrapegraphai.com
