
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsVolumesResponse
    {
        /// <summary>
        /// The time window of the numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseRangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.GetAnalyticsVolumesResponseRange Range { get; set; }

        /// <summary>
        /// The channel the numbers are for. Null when they are for all channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// The size of each entry in `volumes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.GetAnalyticsVolumesResponseBucketJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.GetAnalyticsVolumesResponseBucket Bucket { get; set; }

        /// <summary>
        /// Counts over time, oldest first. Buckets with no requests are included with zeros.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsVolumesResponseVolume> Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsVolumesResponse" /> class.
        /// </summary>
        /// <param name="range">
        /// The time window of the numbers.
        /// </param>
        /// <param name="bucket">
        /// The size of each entry in `volumes`.
        /// </param>
        /// <param name="volumes">
        /// Counts over time, oldest first. Buckets with no requests are included with zeros.
        /// </param>
        /// <param name="channelId">
        /// The channel the numbers are for. Null when they are for all channels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsVolumesResponse(
            global::ModerationAPI.GetAnalyticsVolumesResponseRange range,
            global::ModerationAPI.GetAnalyticsVolumesResponseBucket bucket,
            global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsVolumesResponseVolume> volumes,
            string? channelId)
        {
            this.Range = range;
            this.ChannelId = channelId;
            this.Bucket = bucket;
            this.Volumes = volumes ?? throw new global::System.ArgumentNullException(nameof(volumes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsVolumesResponse" /> class.
        /// </summary>
        public GetAnalyticsVolumesResponse()
        {
        }

    }
}