
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponseActionStat
    {
        /// <summary>
        /// ID of the moderation action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionId { get; set; }

        /// <summary>
        /// Name of the moderation action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionName { get; set; }

        /// <summary>
        /// Number of times this action was taken
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Percentage this action represents of all actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentageOfTotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PercentageOfTotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseActionStat" /> class.
        /// </summary>
        /// <param name="actionId">
        /// ID of the moderation action
        /// </param>
        /// <param name="actionName">
        /// Name of the moderation action
        /// </param>
        /// <param name="count">
        /// Number of times this action was taken
        /// </param>
        /// <param name="percentageOfTotal">
        /// Percentage this action represents of all actions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponseActionStat(
            string actionId,
            string actionName,
            double count,
            double percentageOfTotal)
        {
            this.ActionId = actionId ?? throw new global::System.ArgumentNullException(nameof(actionId));
            this.ActionName = actionName ?? throw new global::System.ArgumentNullException(nameof(actionName));
            this.Count = count;
            this.PercentageOfTotal = percentageOfTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseActionStat" /> class.
        /// </summary>
        public QueueViewOpenGetStatsResponseActionStat()
        {
        }
    }
}