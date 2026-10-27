
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsAuthorsResponse
    {
        /// <summary>
        /// The time window of the numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("range")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.GetAnalyticsAuthorsResponseRangeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.GetAnalyticsAuthorsResponseRange Range { get; set; }

        /// <summary>
        /// The channel the numbers are for. Null when they are for all channels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// The authors with the most flagged requests, largest first. Requests without an author are not included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor> Authors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsAuthorsResponse" /> class.
        /// </summary>
        /// <param name="range">
        /// The time window of the numbers.
        /// </param>
        /// <param name="authors">
        /// The authors with the most flagged requests, largest first. Requests without an author are not included.
        /// </param>
        /// <param name="channelId">
        /// The channel the numbers are for. Null when they are for all channels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsAuthorsResponse(
            global::ModerationAPI.GetAnalyticsAuthorsResponseRange range,
            global::System.Collections.Generic.IList<global::ModerationAPI.GetAnalyticsAuthorsResponseAuthor> authors,
            string? channelId)
        {
            this.Range = range;
            this.ChannelId = channelId;
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsAuthorsResponse" /> class.
        /// </summary>
        public GetAnalyticsAuthorsResponse()
        {
        }

    }
}