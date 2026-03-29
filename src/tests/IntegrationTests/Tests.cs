namespace ScrapeGraphAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ScrapeGraphAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SGAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : Environment.GetEnvironmentVariable("SCRAPEGRAPHAI_API_KEY") is { Length: > 0 } altKeyValue
                    ? altKeyValue
                    : throw new AssertInconclusiveException(
                        "SGAI_API_KEY environment variable is not found.");

        var client = new ScrapeGraphAIClient(apiKey);

        return client;
    }
}
