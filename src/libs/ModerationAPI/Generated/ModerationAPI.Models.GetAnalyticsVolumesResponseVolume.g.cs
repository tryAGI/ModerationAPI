
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsVolumesResponseVolume
    {
        /// <summary>
        /// Start of the bucket, as an ISO 8601 timestamp in UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Start { get; set; }

        /// <summary>
        /// Requests received in the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// Requests flagged in the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Flagged { get; set; }

        /// <summary>
        /// Requests with the recommendation "reject" in the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rejected { get; set; }

        /// <summary>
        /// Requests with the recommendation "review" in the bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentToReview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentToReview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsVolumesResponseVolume" /> class.
        /// </summary>
        /// <param name="start">
        /// Start of the bucket, as an ISO 8601 timestamp in UTC.
        /// </param>
        /// <param name="requests">
        /// Requests received in the bucket.
        /// </param>
        /// <param name="flagged">
        /// Requests flagged in the bucket.
        /// </param>
        /// <param name="rejected">
        /// Requests with the recommendation "reject" in the bucket.
        /// </param>
        /// <param name="sentToReview">
        /// Requests with the recommendation "review" in the bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsVolumesResponseVolume(
            string start,
            int requests,
            int flagged,
            int rejected,
            int sentToReview)
        {
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
            this.Requests = requests;
            this.Flagged = flagged;
            this.Rejected = rejected;
            this.SentToReview = sentToReview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsVolumesResponseVolume" /> class.
        /// </summary>
        public GetAnalyticsVolumesResponseVolume()
        {
        }

    }
}