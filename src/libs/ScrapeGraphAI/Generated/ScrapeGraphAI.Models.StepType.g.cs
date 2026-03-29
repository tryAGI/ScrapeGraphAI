
#nullable enable

namespace ScrapeGraphAI
{
    /// <summary>
    /// Types of workflow steps
    /// </summary>
    public enum StepType
    {
        /// <summary>
        /// 
        /// </summary>
        Action,
        /// <summary>
        /// 
        /// </summary>
        Conditional,
        /// <summary>
        /// 
        /// </summary>
        Extract,
        /// <summary>
        /// 
        /// </summary>
        ExtractMarkdown,
        /// <summary>
        /// 
        /// </summary>
        Loop,
        /// <summary>
        /// 
        /// </summary>
        Navigate,
        /// <summary>
        /// 
        /// </summary>
        Subworkflow,
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepType value)
        {
            return value switch
            {
                StepType.Action => "action",
                StepType.Conditional => "conditional",
                StepType.Extract => "extract",
                StepType.ExtractMarkdown => "extract_markdown",
                StepType.Loop => "loop",
                StepType.Navigate => "navigate",
                StepType.Subworkflow => "subworkflow",
                StepType.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepType? ToEnum(string value)
        {
            return value switch
            {
                "action" => StepType.Action,
                "conditional" => StepType.Conditional,
                "extract" => StepType.Extract,
                "extract_markdown" => StepType.ExtractMarkdown,
                "loop" => StepType.Loop,
                "navigate" => StepType.Navigate,
                "subworkflow" => StepType.Subworkflow,
                "wait" => StepType.Wait,
                _ => null,
            };
        }
    }
}