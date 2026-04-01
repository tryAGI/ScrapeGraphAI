
#nullable enable

namespace ScrapeGraphAI
{
    public partial class UserClient
    {
        partial void PrepareSubmitProductFeedbackV1ProductFeedbackPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ScrapeGraphAI.ProductFeedback request);
        partial void PrepareSubmitProductFeedbackV1ProductFeedbackPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ScrapeGraphAI.ProductFeedback request);
        partial void ProcessSubmitProductFeedbackV1ProductFeedbackPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSubmitProductFeedbackV1ProductFeedbackPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Submit Product Feedback
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ProductFeedbackResponse> SubmitProductFeedbackV1ProductFeedbackPostAsync(

            global::ScrapeGraphAI.ProductFeedback request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSubmitProductFeedbackV1ProductFeedbackPostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::ScrapeGraphAI.PathBuilder(
                path: "/v1/product-feedback",
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
            PrepareSubmitProductFeedbackV1ProductFeedbackPostRequest(
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
            ProcessSubmitProductFeedbackV1ProductFeedbackPostResponse(
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
                ProcessSubmitProductFeedbackV1ProductFeedbackPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ScrapeGraphAI.ProductFeedbackResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::ScrapeGraphAI.ProductFeedbackResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Submit Product Feedback
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="company"></param>
        /// <param name="howDiscovered"></param>
        /// <param name="usageFrequency"></param>
        /// <param name="useCases"></param>
        /// <param name="rating"></param>
        /// <param name="likedMost"></param>
        /// <param name="disliked"></param>
        /// <param name="requestedFeatures"></param>
        /// <param name="setupEasy"></param>
        /// <param name="issues"></param>
        /// <param name="recommendScore"></param>
        /// <param name="improvementSuggestions"></param>
        /// <param name="canContact"></param>
        /// <param name="contactMethod"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScrapeGraphAI.ProductFeedbackResponse> SubmitProductFeedbackV1ProductFeedbackPostAsync(
            global::System.Guid? feedbackId = default,
            string? name = default,
            string? email = default,
            string? company = default,
            string? howDiscovered = default,
            string? usageFrequency = default,
            global::System.Collections.Generic.IList<string>? useCases = default,
            int? rating = default,
            string? likedMost = default,
            string? disliked = default,
            string? requestedFeatures = default,
            bool? setupEasy = default,
            string? issues = default,
            int? recommendScore = default,
            string? improvementSuggestions = default,
            bool? canContact = default,
            string? contactMethod = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new global::ScrapeGraphAI.ProductFeedback
            {
                FeedbackId = feedbackId,
                Name = name,
                Email = email,
                Company = company,
                HowDiscovered = howDiscovered,
                UsageFrequency = usageFrequency,
                UseCases = useCases,
                Rating = rating,
                LikedMost = likedMost,
                Disliked = disliked,
                RequestedFeatures = requestedFeatures,
                SetupEasy = setupEasy,
                Issues = issues,
                RecommendScore = recommendScore,
                ImprovementSuggestions = improvementSuggestions,
                CanContact = canContact,
                ContactMethod = contactMethod,
            };

            return await SubmitProductFeedbackV1ProductFeedbackPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}