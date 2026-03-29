#nullable enable

namespace ScrapeGraphAI;

public partial class ScrapeGraphAIClient
{
#pragma warning disable CA1822 // Mark members as static
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { } apiKey })
        {
            request.Headers.Authorization = null;
            request.Headers.TryAddWithoutValidation("SGAI-APIKEY", apiKey);
        }
    }
#pragma warning restore CA1822 // Mark members as static
}
