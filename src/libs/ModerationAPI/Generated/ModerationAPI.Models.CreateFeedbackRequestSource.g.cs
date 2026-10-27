
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Where the feedback was written: MCP server, agent skill, CLI or API.<br/>
    /// Default Value: api
    /// </summary>
    public enum CreateFeedbackRequestSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Cli,
        /// <summary>
        ///
        /// </summary>
        Mcp,
        /// <summary>
        /// MCP server, agent skill, CLI or API.
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFeedbackRequestSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFeedbackRequestSource value)
        {
            return value switch
            {
                CreateFeedbackRequestSource.Api => "api",
                CreateFeedbackRequestSource.Cli => "cli",
                CreateFeedbackRequestSource.Mcp => "mcp",
                CreateFeedbackRequestSource.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFeedbackRequestSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => CreateFeedbackRequestSource.Api,
                "cli" => CreateFeedbackRequestSource.Cli,
                "mcp" => CreateFeedbackRequestSource.Mcp,
                "skill" => CreateFeedbackRequestSource.Skill,
                _ => null,
            };
        }
    }
}