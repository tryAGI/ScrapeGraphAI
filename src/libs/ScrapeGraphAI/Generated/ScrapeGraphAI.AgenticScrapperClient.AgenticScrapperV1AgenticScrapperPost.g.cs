
#nullable enable

namespace ScrapeGraphAI
{
    public partial class AgenticScrapperClient
    {
        partial void PrepareAgenticScrapperV1AgenticScrapperPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ScrapeGraphAI.AgenticScrapperRequest request);
        partial void PrepareAgenticScrapperV1AgenticScrapperPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ScrapeGraphAI.AgenticScrapperRequest request);
        partial void ProcessAgenticScrapperV1AgenticScrapperPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgenticScrapperV1AgenticScrapperPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Agentic Scrapper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AgenticScrapperResponse> AgenticScrapperV1AgenticScrapperPostAsync(

            global::ScrapeGraphAI.AgenticScrapperRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAgenticScrapperV1AgenticScrapperPostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::ScrapeGraphAI.PathBuilder(
                path: "/v1/agentic-scrapper",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAgenticScrapperV1AgenticScrapperPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgenticScrapperV1AgenticScrapperPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::ScrapeGraphAI.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::ScrapeGraphAI.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::ScrapeGraphAI.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::ScrapeGraphAI.ApiException<global::ScrapeGraphAI.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessAgenticScrapperV1AgenticScrapperPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ScrapeGraphAI.AgenticScrapperResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::ScrapeGraphAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::ScrapeGraphAI.AgenticScrapperResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::ScrapeGraphAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Agentic Scrapper
        /// </summary>
        /// <param name="url"></param>
        /// <param name="userPrompt"></param>
        /// <param name="outputSchema">
        /// Default Value: {}
        /// </param>
        /// <param name="steps">
        /// List of steps to actions to perform on the website<br/>
        /// Default Value: []
        /// </param>
        /// <param name="useSession">
        /// Whether to use a session to scrape the website<br/>
        /// Default Value: false
        /// </param>
        /// <param name="aiExtraction">
        /// Whether to use AI extraction to extract the information<br/>
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="countryCode">
        /// The country code to use for the scrape (e.g. US, GB)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AgenticScrapperResponse> AgenticScrapperV1AgenticScrapperPostAsync(
            string url,
            string? userPrompt = default,
            object? outputSchema = default,
            global::System.Collections.Generic.IList<string>? steps = default,
            bool? useSession = default,
            bool? aiExtraction = default,
            bool? stream = default,
            string? webhookUrl = default,
            string? countryCode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ScrapeGraphAI.AgenticScrapperRequest
            {
                Url = url,
                UserPrompt = userPrompt,
                OutputSchema = outputSchema,
                Steps = steps,
                UseSession = useSession,
                AiExtraction = aiExtraction,
                Stream = stream,
                WebhookUrl = webhookUrl,
                CountryCode = countryCode,
            };

            return await AgenticScrapperV1AgenticScrapperPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}