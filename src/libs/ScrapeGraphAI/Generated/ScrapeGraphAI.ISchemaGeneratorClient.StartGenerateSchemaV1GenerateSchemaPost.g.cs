#nullable enable

namespace ScrapeGraphAI
{
    public partial interface ISchemaGeneratorClient
    {
        /// <summary>
        /// Generate or modify a JSON schema based on a search query<br/>
        /// Generate a refined search prompt and a structured JSON schema for analyzing search results.<br/>
        ///     Optionally modify an existing schema to better fit the current search query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SchemaGenerationResponse> StartGenerateSchemaV1GenerateSchemaPostAsync(

            global::ScrapeGraphAI.SchemaGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate or modify a JSON schema based on a search query<br/>
        /// Generate a refined search prompt and a structured JSON schema for analyzing search results.<br/>
        ///     Optionally modify an existing schema to better fit the current search query.
        /// </summary>
        /// <param name="userPrompt">
        /// The user's search query to be refined
        /// </param>
        /// <param name="existingSchema">
        /// Optional existing JSON schema to modify/extend
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.SchemaGenerationResponse> StartGenerateSchemaV1GenerateSchemaPostAsync(
            string userPrompt,
            object? existingSchema = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}