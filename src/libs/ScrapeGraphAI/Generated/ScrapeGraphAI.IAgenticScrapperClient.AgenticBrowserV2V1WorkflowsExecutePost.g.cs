#nullable enable

namespace ScrapeGraphAI
{
    public partial interface IAgenticScrapperClient
    {
        /// <summary>
        /// Agentic Browser V2
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.WorkflowExecutionResult> AgenticBrowserV2V1WorkflowsExecutePostAsync(

            global::ScrapeGraphAI.WorkflowDefinition request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agentic Browser V2
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScrapeGraphAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.AutoSDKHttpResponse<global::ScrapeGraphAI.WorkflowExecutionResult>> AgenticBrowserV2V1WorkflowsExecutePostAsResponseAsync(

            global::ScrapeGraphAI.WorkflowDefinition request,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Agentic Browser V2
        /// </summary>
        /// <param name="workflowId">
        /// Unique workflow identifier
        /// </param>
        /// <param name="name">
        /// Human-readable workflow name
        /// </param>
        /// <param name="description">
        /// Workflow description
        /// </param>
        /// <param name="startUrl">
        /// Initial URL to navigate to (can be overridden)
        /// </param>
        /// <param name="useSession">
        /// Whether to use persistent browser session<br/>
        /// Default Value: false
        /// </param>
        /// <param name="steps">
        /// Ordered list of workflow steps
        /// </param>
        /// <param name="initialContext">
        /// Initial variables/context (e.g., {'email': 'user@example.com', 'password': 'secret'})
        /// </param>
        /// <param name="outputVariables">
        /// List of variables to include in final output
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScrapeGraphAI.WorkflowExecutionResult> AgenticBrowserV2V1WorkflowsExecutePostAsync(
            string name,
            global::System.Collections.Generic.IList<global::ScrapeGraphAI.AnyOf<global::ScrapeGraphAI.NavigationStep, global::ScrapeGraphAI.ActionStep, global::ScrapeGraphAI.ExtractionStep, global::ScrapeGraphAI.MarkdownExtractionStep, global::ScrapeGraphAI.LoopStep, global::ScrapeGraphAI.ConditionalStep, global::ScrapeGraphAI.SubWorkflowStep, global::ScrapeGraphAI.WaitStep>> steps,
            string? workflowId = default,
            string? description = default,
            string? startUrl = default,
            bool? useSession = default,
            object? initialContext = default,
            global::System.Collections.Generic.IList<string>? outputVariables = default,
            global::ScrapeGraphAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}