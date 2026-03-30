
#nullable enable

namespace ScrapeGraphAI
{
    public sealed partial class ScrapeGraphAIClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::ScrapeGraphAI.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "SGAI-APIKEY",
                Value = apiKey,
            });
        }
    }
}