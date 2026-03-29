
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Metadata about the moderation request
    /// </summary>
    public sealed partial class NewModerateModerateResponseMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseMetaStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponseMetaStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// The unique key of the channel where the content was handled. Either the channel provided by you or automatically routed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChannelKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_time")]
        public string? ProcessingTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseMeta" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="timestamp"></param>
        /// <param name="channelKey">
        /// The unique key of the channel where the content was handled. Either the channel provided by you or automatically routed.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="processingTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseMeta(
            global::ModerationAPI.NewModerateModerateResponseMetaStatus status,
            double timestamp,
            string channelKey,
            double usage,
            string? processingTime)
        {
            this.Status = status;
            this.Timestamp = timestamp;
            this.ChannelKey = channelKey ?? throw new global::System.ArgumentNullException(nameof(channelKey));
            this.Usage = usage;
            this.ProcessingTime = processingTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseMeta" /> class.
        /// </summary>
        public NewModerateModerateResponseMeta()
        {
        }
    }
}