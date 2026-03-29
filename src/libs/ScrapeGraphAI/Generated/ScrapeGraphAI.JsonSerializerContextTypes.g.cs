
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ScrapeGraphAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ActionStep? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.StepType? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AgenticScraperHistoryResponse? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.AgenticScraperRequestDB>? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AgenticScraperRequestDB? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AgenticScrapperStatus? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AgenticScrapperLiveSessionUrlRequest? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AgenticScrapperLiveSessionUrlResponse? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AgenticScrapperRequest? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AgenticScrapperResponse? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AgenticScrapperStopSessionRequest? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.CompletedMarkdownifyResponse? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.MarkdownifyStatus? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.CompletedSearchScraperResponse? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Guid? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SearchScraperStatus? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.CompletedSmartscraperResponse? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SmartscraperStatus? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AnyOf<object, string, object>? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ConditionalStep? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>>? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.NavigationStep? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ExtractionStep? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.MarkdownExtractionStep? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.LoopStep? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SubWorkflowStep? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.WaitStep? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.CrawlJob? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.CrawlJobRules2? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.CrawlStatus? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.CrawlerHistoryResponse? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.CrawlerRequestDB>? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.CrawlerRequestDB? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.CreditsResponse? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.DeductCreditsBody? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.DeductCreditsResponse? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.EndPointSuggestionRequest? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.EndPointSuggestions? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.EndpointSuggestion>? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.EndpointSuggestion? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.EndPointSuggestionsResponse? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.EndpointParameter? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.EndpointParameter>? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.FeedbackCreate? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.FeedbackResponse? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.HTTPValidationError? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.ValidationError>? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ValidationError? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.JobExecutionListResponse? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.JobExecutionResponse>? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.JobExecutionResponse? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.JobTriggerResponse? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.MarkdownifyHistoryResponse? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.MarkdownifyRequestDB>? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.MarkdownifyRequestDB? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.MarkdownifyRequest? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.MarkdownifyRequestStatus? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ProductFeedback? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ProductFeedbackResponse? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.QueryRedisCacheByPatternRequest? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ScheduledJobCreate? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ServiceType? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ScheduledJobListResponse? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.ScheduledJobResponse>? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ScheduledJobResponse? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SchemaGenerationRequest? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SchemaGenerationResponse? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ScrapeHistoryResponse? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.ScrapeRequestDB>? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ScrapeRequestDB? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ScrapeRequest? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.ScrapeStatus? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SearchScraperRequest? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.TimeRange? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SearchscraperHistoryResponse? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.SearchscraperRequestDB>? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SearchscraperRequestDB? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SiteMonitorCreate? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SiteMonitorExtractionConfig? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SiteMonitorListResponse? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.SiteMonitorResponse>? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SiteMonitorResponse? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SiteMonitorUpdate? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SitemapHistoryResponse? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.SitemapRequestDB>? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SitemapRequestDB? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SitemapRequest? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SitemapResponse? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SmartscraperHistoryResponse? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.SmartscraperRequestDB>? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SmartscraperRequestDB? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.SmartscraperRequest? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.StepResult? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.WorkflowDefinition? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.TimelineEntry? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.UsageTimelineResponse? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.TimelineEntry>? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<string, int?>>? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.AnyOf<string, int?>? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.WorkflowExecutionResult? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScrapeGraphAI.StepResult>? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ScrapeGraphAI.GetUsageTimelineV1UsageTimelineGetDays2? Type110 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.AgenticScraperRequestDB>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.CrawlerRequestDB>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.EndpointSuggestion>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.EndpointParameter>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.ValidationError>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.JobExecutionResponse>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.MarkdownifyRequestDB>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.ScheduledJobResponse>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.ScrapeRequestDB>? ListType10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.SearchscraperRequestDB>? ListType11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.SiteMonitorResponse>? ListType12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.SitemapRequestDB>? ListType13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.SmartscraperRequestDB>? ListType14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.TimelineEntry>? ListType15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.AnyOf<string, int?>>? ListType16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ScrapeGraphAI.StepResult>? ListType17 { get; set; }
    }
}