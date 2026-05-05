
#nullable enable

namespace ScrapeGraphAI
{
    public partial class SmartScraperClient
    {


        private static readonly global::ScrapeGraphAI.EndPointSecurityRequirement s_StartSmartscraperV1SmartscraperPostSecurityRequirement0 =
            new global::ScrapeGraphAI.EndPointSecurityRequirement
            {
                Authorizations = new global::ScrapeGraphAI.EndPointAuthorizationRequirement[]
                {                    new global::ScrapeGraphAI.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeySgaiApikey",
                        Location = "Header",
                        Name = "SGAI-APIKEY",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::ScrapeGraphAI.EndPointSecurityRequirement[] s_StartSmartscraperV1SmartscraperPostSecurityRequirements =
            new global::ScrapeGraphAI.EndPointSecurityRequirement[]
            {                s_StartSmartscraperV1SmartscraperPostSecurityRequirement0,
            };
        partial void PrepareStartSmartscraperV1SmartscraperPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ScrapeGraphAI.SmartscraperRequest request);
        partial void PrepareStartSmartscraperV1SmartscraperPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ScrapeGraphAI.SmartscraperRequest request);
        partial void ProcessStartSmartscraperV1SmartscraperPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStartSmartscraperV1SmartscraperPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start Smartscraper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.CompletedSmartscraperResponse> StartSmartscraperV1SmartscraperPostAsync(

            global::ScrapeGraphAI.SmartscraperRequest request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await StartSmartscraperV1SmartscraperPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Start Smartscraper
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.CompletedSmartscraperResponse>> StartSmartscraperV1SmartscraperPostAsResponseAsync(

            global::ScrapeGraphAI.SmartscraperRequest request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStartSmartscraperV1SmartscraperPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ScrapeGraphAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StartSmartscraperV1SmartscraperPostSecurityRequirements,
                operationName: "StartSmartscraperV1SmartscraperPostAsync");

            using var __timeoutCancellationTokenSource = global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::ScrapeGraphAI.PathBuilder(
                                path: "/v1/smartscraper",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareStartSmartscraperV1SmartscraperPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartSmartscraperV1SmartscraperPost",
                                methodName: "StartSmartscraperV1SmartscraperPostAsync",
                                pathTemplate: "\"/v1/smartscraper\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartSmartscraperV1SmartscraperPost",
                                methodName: "StartSmartscraperV1SmartscraperPostAsync",
                                pathTemplate: "\"/v1/smartscraper\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartSmartscraperV1SmartscraperPost",
                                methodName: "StartSmartscraperV1SmartscraperPostAsync",
                                pathTemplate: "\"/v1/smartscraper\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessStartSmartscraperV1SmartscraperPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartSmartscraperV1SmartscraperPost",
                                methodName: "StartSmartscraperV1SmartscraperPostAsync",
                                pathTemplate: "\"/v1/smartscraper\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartSmartscraperV1SmartscraperPost",
                                methodName: "StartSmartscraperV1SmartscraperPostAsync",
                                pathTemplate: "\"/v1/smartscraper\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::ScrapeGraphAI.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::ScrapeGraphAI.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessStartSmartscraperV1SmartscraperPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ScrapeGraphAI.CompletedSmartscraperResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.CompletedSmartscraperResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ScrapeGraphAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::ScrapeGraphAI.CompletedSmartscraperResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.CompletedSmartscraperResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ScrapeGraphAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Start Smartscraper
        /// </summary>
        /// <param name="websiteUrl">
        /// The URL of the website to scrape (optional for Smartscraper)
        /// </param>
        /// <param name="renderHeavyJs">
        /// Whether to render heavy JS<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mock">
        /// Default Value: false
        /// </param>
        /// <param name="stealth">
        /// Default Value: false
        /// </param>
        /// <param name="branding">
        /// Default Value: false
        /// </param>
        /// <param name="stream">
        /// Whether to return streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="countryCode">
        /// The country code to use for the scrape
        /// </param>
        /// <param name="waitMs">
        /// The number of milliseconds to wait before scraping the website<br/>
        /// Default Value: 3000
        /// </param>
        /// <param name="userPrompt">
        /// Example: Extract info about the company
        /// </param>
        /// <param name="websiteHtml">
        /// HTML content, maximum size 2MB<br/>
        /// Example: &lt;html&gt;&lt;body&gt;&lt;h1&gt;Title&lt;/h1&gt;&lt;p&gt;Content&lt;/p&gt;&lt;/body&gt;&lt;/html&gt;
        /// </param>
        /// <param name="websiteMarkdown">
        /// Markdown content, maximum size 2MB<br/>
        /// Example: # Title<br/>
        /// This is some content in markdown format.
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="headers">
        /// Optional headers to send with the request, including cookies and user agent<br/>
        /// Example: {"Cookie":"cookie1=value1; cookie2=value2","User-Agent":"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"}
        /// </param>
        /// <param name="numberOfScrolls">
        /// Number of scroll operations to perform for infinite scrolling (0 = disabled, range: 1-100). Values between 1-9 will be automatically set to 10.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="totalPages">
        /// Total number of pages to scrape if pagination enabled<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="steps">
        /// List of steps to actions to perform on the website
        /// </param>
        /// <param name="cookies">
        /// Cookies to send with the request<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="plainText">
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="offset">
        /// Offset to start scraping from<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="isMultipageChild">
        /// Whether this is a multi-page child request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.CompletedSmartscraperResponse> StartSmartscraperV1SmartscraperPostAsync(
            string userPrompt,
            string? websiteUrl = default,
            bool? renderHeavyJs = default,
            bool? mock = default,
            bool? stealth = default,
            bool? branding = default,
            bool? stream = default,
            string? countryCode = default,
            int? waitMs = default,
            string? websiteHtml = default,
            string? websiteMarkdown = default,
            object? outputSchema = default,
            global::System.Collections.Generic.Dictionary<string, string>? headers = default,
            int? numberOfScrolls = default,
            int? totalPages = default,
            global::System.Collections.Generic.IList<string>? steps = default,
            global::System.Collections.Generic.Dictionary<string, string>? cookies = default,
            bool? plainText = default,
            string? webhookUrl = default,
            int? offset = default,
            bool? isMultipageChild = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ScrapeGraphAI.SmartscraperRequest
            {
                WebsiteUrl = websiteUrl,
                RenderHeavyJs = renderHeavyJs,
                Mock = mock,
                Stealth = stealth,
                Branding = branding,
                Stream = stream,
                CountryCode = countryCode,
                WaitMs = waitMs,
                UserPrompt = userPrompt,
                WebsiteHtml = websiteHtml,
                WebsiteMarkdown = websiteMarkdown,
                OutputSchema = outputSchema,
                Headers = headers,
                NumberOfScrolls = numberOfScrolls,
                TotalPages = totalPages,
                Steps = steps,
                Cookies = cookies,
                PlainText = plainText,
                WebhookUrl = webhookUrl,
                Offset = offset,
                IsMultipageChild = isMultipageChild,
            };

            return await StartSmartscraperV1SmartscraperPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}