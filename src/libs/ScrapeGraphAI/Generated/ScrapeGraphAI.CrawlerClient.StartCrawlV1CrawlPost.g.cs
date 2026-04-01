
#nullable enable

namespace ScrapeGraphAI
{
    public partial class CrawlerClient
    {
        partial void PrepareStartCrawlV1CrawlPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ScrapeGraphAI.CrawlJob request);
        partial void PrepareStartCrawlV1CrawlPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ScrapeGraphAI.CrawlJob request);
        partial void ProcessStartCrawlV1CrawlPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStartCrawlV1CrawlPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start Crawl<br/>
        /// Start a new crawl job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> StartCrawlV1CrawlPostAsync(

            global::ScrapeGraphAI.CrawlJob request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStartCrawlV1CrawlPostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::ScrapeGraphAI.PathBuilder(
                path: "/v1/crawl",
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
            PrepareStartCrawlV1CrawlPostRequest(
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
            ProcessStartCrawlV1CrawlPostResponse(
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
                ProcessStartCrawlV1CrawlPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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

                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// Start Crawl<br/>
        /// Start a new crawl job.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="depth">
        /// Default Value: 1
        /// </param>
        /// <param name="breadth">
        /// Maximum number of links to crawl per depth level. If None, unlimited (default). Ignored when sitemap=True.
        /// </param>
        /// <param name="maxPages">
        /// Default Value: 10
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="schema"></param>
        /// <param name="rules"></param>
        /// <param name="sitemap">
        /// Default Value: true
        /// </param>
        /// <param name="renderHeavyJs">
        /// Default Value: false
        /// </param>
        /// <param name="extractionMode">
        /// Default Value: true
        /// </param>
        /// <param name="stealth">
        /// Enable stealth mode to avoid bot detection<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mock">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="readerMode">
        /// Default Value: false
        /// </param>
        /// <param name="waitMs">
        /// Default Value: 3000
        /// </param>
        /// <param name="countryCode">
        /// The country code to use for fetching (e.g. US, GB)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> StartCrawlV1CrawlPostAsync(
            string url,
            int? depth = default,
            int? breadth = default,
            int? maxPages = default,
            string? prompt = default,
            object? schema = default,
            global::ScrapeGraphAI.CrawlJobRules2? rules = default,
            bool? sitemap = default,
            bool? renderHeavyJs = default,
            bool? extractionMode = default,
            bool? stealth = default,
            bool? mock = default,
            string? webhookUrl = default,
            bool? readerMode = default,
            int? waitMs = default,
            string? countryCode = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ScrapeGraphAI.CrawlJob
            {
                Url = url,
                Depth = depth,
                Breadth = breadth,
                MaxPages = maxPages,
                Prompt = prompt,
                Schema = schema,
                Rules = rules,
                Sitemap = sitemap,
                RenderHeavyJs = renderHeavyJs,
                ExtractionMode = extractionMode,
                Stealth = stealth,
                Mock = mock,
                WebhookUrl = webhookUrl,
                ReaderMode = readerMode,
                WaitMs = waitMs,
                CountryCode = countryCode,
            };

            return await StartCrawlV1CrawlPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}