
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsPoliciesResponse
    {
        /// <summary>
        /// The time window of the numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.GetAnalyticsPoliciesResponseRangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.GetAnalyticsPoliciesResponseRange Range { get; set; }

        /// <summary>
        /// The channel the numbers are for. Null when they are for all channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// The policy labels with the most flagged requests, largest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie> Policies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsPoliciesResponse" /> class.
        /// </summary>
        /// <param name="range">
        /// The time window of the numbers.
        /// </param>
        /// <param name="policies">
        /// The policy labels with the most flagged requests, largest first.
        /// </param>
        /// <param name="channelId">
        /// The channel the numbers are for. Null when they are for all channels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsPoliciesResponse(
            global::ModerationAPI.GetAnalyticsPoliciesResponseRange range,
            global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsPoliciesResponsePolicie> policies,
            string? channelId)
        {
            this.Range = range;
            this.ChannelId = channelId;
            this.Policies = policies ?? throw new global::System.ArgumentNullException(nameof(policies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsPoliciesResponse" /> class.
        /// </summary>
        public GetAnalyticsPoliciesResponse()
        {
        }

    }
}