
#nullable enable

namespace ScrapeGraphAI
{
    public partial class ScheduledJobsClient
    {


        private static readonly global::ScrapeGraphAI.EndPointSecurityRequirement s_ReplaceScheduledJobV1ScheduledJobsJobIdPutSecurityRequirement0 =
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
        private static readonly global::ScrapeGraphAI.EndPointSecurityRequirement[] s_ReplaceScheduledJobV1ScheduledJobsJobIdPutSecurityRequirements =
            new global::ScrapeGraphAI.EndPointSecurityRequirement[]
            {                s_ReplaceScheduledJobV1ScheduledJobsJobIdPutSecurityRequirement0,
            };
        partial void PrepareReplaceScheduledJobV1ScheduledJobsJobIdPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string jobId,
            global::ScrapeGraphAI.ScheduledJobCreate request);
        partial void PrepareReplaceScheduledJobV1ScheduledJobsJobIdPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string jobId,
            global::ScrapeGraphAI.ScheduledJobCreate request);
        partial void ProcessReplaceScheduledJobV1ScheduledJobsJobIdPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReplaceScheduledJobV1ScheduledJobsJobIdPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Replace Scheduled Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ScheduledJobResponse> ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync(
            string jobId,

            global::ScrapeGraphAI.ScheduledJobCreate request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareReplaceScheduledJobV1ScheduledJobsJobIdPutArguments(
                httpClient: HttpClient,
                jobId: ref jobId,
                request: request);


            var __authorizations = global::ScrapeGraphAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ReplaceScheduledJobV1ScheduledJobsJobIdPutSecurityRequirements,
                operationName: "ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync");

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
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::ScrapeGraphAI.PathBuilder(
                                path: $"/v1/scheduled-jobs/{jobId}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
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
                PrepareReplaceScheduledJobV1ScheduledJobsJobIdPutRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    jobId: jobId!,
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
                                operationId: "ReplaceScheduledJobV1ScheduledJobsJobIdPut",
                                methodName: "ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync",
                                pathTemplate: "$\"/v1/scheduled-jobs/{jobId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReplaceScheduledJobV1ScheduledJobsJobIdPut",
                                methodName: "ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync",
                                pathTemplate: "$\"/v1/scheduled-jobs/{jobId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReplaceScheduledJobV1ScheduledJobsJobIdPut",
                                methodName: "ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync",
                                pathTemplate: "$\"/v1/scheduled-jobs/{jobId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessReplaceScheduledJobV1ScheduledJobsJobIdPutResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReplaceScheduledJobV1ScheduledJobsJobIdPut",
                                methodName: "ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync",
                                pathTemplate: "$\"/v1/scheduled-jobs/{jobId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ScrapeGraphAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ReplaceScheduledJobV1ScheduledJobsJobIdPut",
                                methodName: "ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync",
                                pathTemplate: "$\"/v1/scheduled-jobs/{jobId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                                ProcessReplaceScheduledJobV1ScheduledJobsJobIdPutResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::ScrapeGraphAI.ScheduledJobResponse.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::ScrapeGraphAI.ScheduledJobResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Replace Scheduled Job
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="jobName">
        /// Human-readable name for the scheduled job
        /// </param>
        /// <param name="serviceType">
        /// Type of service to run: smartscraper, searchscraper, markdownify, or smartcrawler
        /// </param>
        /// <param name="cronExpression">
        /// Standard 5-field cron expression (minute hour day month day_of_week) in UTC timezone. All times are interpreted as UTC (e.g., '0 9 * * 1' for 9 AM UTC every Monday)
        /// </param>
        /// <param name="jobConfig">
        /// Service-specific configuration that matches the service's request schema
        /// </param>
        /// <param name="isActive">
        /// Whether the job is active and should be scheduled<br/>
        /// Default Value: true
        /// </param>
        /// <param name="webhookUrl">
        /// Webhook URL to send the job result to
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ScheduledJobResponse> ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync(
            string jobId,
            string jobName,
            global::ScrapeGraphAI.ServiceType serviceType,
            string cronExpression,
            object jobConfig,
            bool? isActive = default,
            string? webhookUrl = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ScrapeGraphAI.ScheduledJobCreate
            {
                JobName = jobName,
                ServiceType = serviceType,
                CronExpression = cronExpression,
                JobConfig = jobConfig,
                IsActive = isActive,
                WebhookUrl = webhookUrl,
            };

            return await ReplaceScheduledJobV1ScheduledJobsJobIdPutAsync(
                jobId: jobId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}