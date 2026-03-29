
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend
    {
        /// <summary>
        /// Content flag/label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Trend indicator (-1 to 1) showing if this type of flagged content is increasing or decreasing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Trend { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend" /> class.
        /// </summary>
        /// <param name="label">
        /// Content flag/label
        /// </param>
        /// <param name="trend">
        /// Trend indicator (-1 to 1) showing if this type of flagged content is increasing or decreasing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend(
            string label,
            double trend)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Trend = trend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend" /> class.
        /// </summary>
        public QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend()
        {
        }
    }
}