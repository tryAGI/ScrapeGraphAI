
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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "SGAI-APIKEY")
                {
                    Authorizations.RemoveAt(i);
                }
            }

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