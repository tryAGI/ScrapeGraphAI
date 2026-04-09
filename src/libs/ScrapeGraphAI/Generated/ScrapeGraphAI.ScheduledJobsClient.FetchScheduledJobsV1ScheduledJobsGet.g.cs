
#nullable enable

namespace ScrapeGraphAI
{
    public partial class ScheduledJobsClient
    {


        private static readonly global::ScrapeGraphAI.EndPointSecurityRequirement s_FetchScheduledJobsV1ScheduledJobsGetSecurityRequirement0 =
            new global::ScrapeGraphAI.EndPointSecurityRequirement
            {
                Authorizations = new global::ScrapeGraphAI.EndPointAuthorizationRequirement[]
                {                    new global::ScrapeGraphAI.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "SGAI-APIKEY",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::ScrapeGraphAI.EndPointSecurityRequirement[] s_FetchScheduledJobsV1ScheduledJobsGetSecurityRequirements =
            new global::ScrapeGraphAI.EndPointSecurityRequirement[]
            {                s_FetchScheduledJobsV1ScheduledJobsGetSecurityRequirement0,
            };
        partial void PrepareFetchScheduledJobsV1ScheduledJobsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? pageSize,
            global::ScrapeGraphAI.ServiceType? serviceType,
            bool? isActive);
        partial void PrepareFetchScheduledJobsV1ScheduledJobsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? pageSize,
            global::ScrapeGraphAI.ServiceType? serviceType,
            bool? isActive);
        partial void ProcessFetchScheduledJobsV1ScheduledJobsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFetchScheduledJobsV1ScheduledJobsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Fetch Scheduled Jobs<br/>
        /// Get user's scheduled jobs with pagination
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of jobs per page<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="serviceType">
        /// Filter by service type
        /// </param>
        /// <param name="isActive">
        /// Filter by active status
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ScheduledJobListResponse> FetchScheduledJobsV1ScheduledJobsGetAsync(
            int? page = default,
            int? pageSize = default,
            global::ScrapeGraphAI.ServiceType? serviceType = default,
            bool? isActive = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFetchScheduledJobsV1ScheduledJobsGetArguments(
                httpClient: HttpClient,
                page: ref page,
                pageSize: ref pageSize,
                serviceType: serviceType,
                isActive: isActive);


            var __authorizations = global::ScrapeGraphAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_FetchScheduledJobsV1ScheduledJobsGetSecurityRequirements,
                operationName: "FetchScheduledJobsV1ScheduledJobsGetAsync");

            var __pathBuilder = new global::ScrapeGraphAI.PathBuilder(
                path: "/v1/scheduled-jobs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("service_type", serviceType?.ToString())
                .AddOptionalParameter("is_active", isActive?.ToString().ToLowerInvariant()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareFetchScheduledJobsV1ScheduledJobsGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                page: page,
                pageSize: pageSize,
                serviceType: serviceType,
                isActive: isActive);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessFetchScheduledJobsV1ScheduledJobsGetResponse(
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
                ProcessFetchScheduledJobsV1ScheduledJobsGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ScrapeGraphAI.ScheduledJobListResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::ScrapeGraphAI.ScheduledJobListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}