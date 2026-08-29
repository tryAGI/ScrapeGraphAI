
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ScrapeGraphAI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ScrapeGraphAI.JsonConverters.AgenticScrapperStatusJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.AgenticScrapperStatusNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.CrawlStatusJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.CrawlStatusNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.MarkdownifyRequestStatusJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.MarkdownifyRequestStatusNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.MarkdownifyStatusJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.MarkdownifyStatusNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.ScrapeStatusJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.ScrapeStatusNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.SearchScraperStatusJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.SearchScraperStatusNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.ServiceTypeJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.ServiceTypeNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.SmartscraperStatusJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.SmartscraperStatusNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.StepTypeJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.StepTypeNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.TimeRangeJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.TimeRangeNullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.GetUsageTimelineV1UsageTimelineGetDays2JsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.GetUsageTimelineV1UsageTimelineGetDays2NullableJsonConverter),

            typeof(global::ScrapeGraphAI.JsonConverters.AnyOfJsonConverter<object, string, object>),

            typeof(global::ScrapeGraphAI.JsonConverters.AnyOfJsonConverter<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>),

            typeof(global::ScrapeGraphAI.JsonConverters.AnyOfJsonConverter<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>),

            typeof(global::ScrapeGraphAI.JsonConverters.AnyOfJsonConverter<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>),

            typeof(global::ScrapeGraphAI.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::ScrapeGraphAI.JsonConverters.AnyOfJsonConverter<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>),

            typeof(global::ScrapeGraphAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ActionStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.StepType), TypeInfoPropertyName = "StepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AgenticScraperHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.AgenticScraperRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AgenticScraperRequestDB))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AgenticScrapperStatus), TypeInfoPropertyName = "AgenticScrapperStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AgenticScrapperLiveSessionUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AgenticScrapperLiveSessionUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AgenticScrapperRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AgenticScrapperResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AgenticScrapperStopSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.CompletedMarkdownifyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.MarkdownifyStatus), TypeInfoPropertyName = "MarkdownifyStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.CompletedSearchScraperResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SearchScraperStatus), TypeInfoPropertyName = "SearchScraperStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.CompletedSmartscraperResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SmartscraperStatus), TypeInfoPropertyName = "SmartscraperStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AnyOf<object, string, object>), TypeInfoPropertyName = "AnyOfObjectStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ConditionalStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>), TypeInfoPropertyName = "AnyOfNavigationStepActionStepExtractionStepMarkdownExtractionStepLoopStepConditionalStepSubWorkflowStepWaitStep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.NavigationStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ExtractionStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.MarkdownExtractionStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.LoopStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SubWorkflowStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.WaitStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.CrawlJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.CrawlJobRules2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.CrawlStatus), TypeInfoPropertyName = "CrawlStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.CrawlerHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.CrawlerRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.CrawlerRequestDB))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.CreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.DeductCreditsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.DeductCreditsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.EndPointSuggestionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.EndPointSuggestions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.EndpointSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.EndpointSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.EndPointSuggestionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.EndpointParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.EndpointParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.FeedbackCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.FeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.JobExecutionListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.JobExecutionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.JobExecutionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.JobTriggerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.MarkdownifyHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.MarkdownifyRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.MarkdownifyRequestDB))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.MarkdownifyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.MarkdownifyRequestStatus), TypeInfoPropertyName = "MarkdownifyRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ProductFeedback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ProductFeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.QueryRedisCacheByPatternRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ScheduledJobCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ServiceType), TypeInfoPropertyName = "ServiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ScheduledJobListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.ScheduledJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ScheduledJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SchemaGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SchemaGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ScrapeHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.ScrapeRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ScrapeRequestDB))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ScrapeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.ScrapeStatus), TypeInfoPropertyName = "ScrapeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SearchScraperRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.TimeRange), TypeInfoPropertyName = "TimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SearchscraperHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.SearchscraperRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SearchscraperRequestDB))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SiteMonitorCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SiteMonitorExtractionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SiteMonitorListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.SiteMonitorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SiteMonitorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SiteMonitorUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SitemapHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.SitemapRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SitemapRequestDB))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SitemapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SitemapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SmartscraperHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.SmartscraperRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SmartscraperRequestDB))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.SmartscraperRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.StepResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.WorkflowDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.TimelineEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.UsageTimelineResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.TimelineEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.WorkflowExecutionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScrapeGraphAI.StepResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScrapeGraphAI.GetUsageTimelineV1UsageTimelineGetDays2), TypeInfoPropertyName = "GetUsageTimelineV1UsageTimelineGetDays22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.AgenticScraperRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.CrawlerRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.EndpointSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.EndpointParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.JobExecutionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.MarkdownifyRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.ScheduledJobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.ScrapeRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.SearchscraperRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.SiteMonitorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.SitemapRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.SmartscraperRequestDB>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.TimelineEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScrapeGraphAI.StepResult>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}