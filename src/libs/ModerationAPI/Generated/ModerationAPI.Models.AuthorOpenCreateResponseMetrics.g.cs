
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorOpenCreateResponseMetrics
    {
        /// <summary>
        /// Total pieces of content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalContent { get; set; }

        /// <summary>
        /// Number of flagged content pieces
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged_content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FlaggedContent { get; set; }

        /// <summary>
        /// Average sentiment score of content (-1 to 1). Requires a sentiment model in your project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_sentiment")]
        public double? AverageSentiment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenCreateResponseMetrics" /> class.
        /// </summary>
        /// <param name="totalContent">
        /// Total pieces of content
        /// </param>
        /// <param name="flaggedContent">
        /// Number of flagged content pieces
        /// </param>
        /// <param name="averageSentiment">
        /// Average sentiment score of content (-1 to 1). Requires a sentiment model in your project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorOpenCreateResponseMetrics(
            double totalContent,
            double flaggedContent,
            double? averageSentiment)
        {
            this.TotalContent = totalContent;
            this.FlaggedContent = flaggedContent;
            this.AverageSentiment = averageSentiment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenCreateResponseMetrics" /> class.
        /// </summary>
        public AuthorOpenCreateResponseMetrics()
        {
        }
    }
}