
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsSummaryResponseFlagRateSpike
    {
        /// <summary>
        /// How many times higher the recent flag rate is than the baseline, for example 2.4.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multiple")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Multiple { get; set; }

        /// <summary>
        /// The flag rate in the last 2 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentFlagRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RecentFlagRate { get; set; }

        /// <summary>
        /// The flag rate in the 30 days before that.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baselineFlagRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BaselineFlagRate { get; set; }

        /// <summary>
        /// Flagged requests in the last 2 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentFlagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RecentFlagged { get; set; }

        /// <summary>
        /// Requests in the last 2 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RecentRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryResponseFlagRateSpike" /> class.
        /// </summary>
        /// <param name="multiple">
        /// How many times higher the recent flag rate is than the baseline, for example 2.4.
        /// </param>
        /// <param name="recentFlagRate">
        /// The flag rate in the last 2 days.
        /// </param>
        /// <param name="baselineFlagRate">
        /// The flag rate in the 30 days before that.
        /// </param>
        /// <param name="recentFlagged">
        /// Flagged requests in the last 2 days.
        /// </param>
        /// <param name="recentRequests">
        /// Requests in the last 2 days.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsSummaryResponseFlagRateSpike(
            double multiple,
            double recentFlagRate,
            double baselineFlagRate,
            int recentFlagged,
            int recentRequests)
        {
            this.Multiple = multiple;
            this.RecentFlagRate = recentFlagRate;
            this.BaselineFlagRate = baselineFlagRate;
            this.RecentFlagged = recentFlagged;
            this.RecentRequests = recentRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryResponseFlagRateSpike" /> class.
        /// </summary>
        public GetAnalyticsSummaryResponseFlagRateSpike()
        {
        }

    }
}