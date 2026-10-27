
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsChannelsResponse
    {
        /// <summary>
        /// The time window of the numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.GetAnalyticsChannelsResponseRangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.GetAnalyticsChannelsResponseRange Range { get; set; }

        /// <summary>
        /// Requests and flags per channel. Channels with no requests in the window are not included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsChannelsResponseChannel> Channels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsChannelsResponse" /> class.
        /// </summary>
        /// <param name="range">
        /// The time window of the numbers.
        /// </param>
        /// <param name="channels">
        /// Requests and flags per channel. Channels with no requests in the window are not included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsChannelsResponse(
            global::ModerationAPI.GetAnalyticsChannelsResponseRange range,
            global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsChannelsResponseChannel> channels)
        {
            this.Range = range;
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsChannelsResponse" /> class.
        /// </summary>
        public GetAnalyticsChannelsResponse()
        {
        }

    }
}