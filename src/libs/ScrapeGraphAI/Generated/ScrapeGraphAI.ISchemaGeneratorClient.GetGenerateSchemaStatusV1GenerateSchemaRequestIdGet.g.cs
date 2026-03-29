#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISchemaGeneratorClient
    {
        /// <summary>
        /// Get Generate Schema Status
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetGenerateSchemaStatusV1GenerateSchemaRequestIdGetAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}