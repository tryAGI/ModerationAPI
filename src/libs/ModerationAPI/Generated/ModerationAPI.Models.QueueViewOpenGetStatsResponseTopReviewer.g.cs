
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponseTopReviewer
    {
        /// <summary>
        /// The user ID of the reviewer. `null` for items resolved with an API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The name of the reviewer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Number of items the reviewer resolved in the period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReviewCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTopReviewer" /> class.
        /// </summary>
        /// <param name="reviewCount">
        /// Number of items the reviewer resolved in the period.
        /// </param>
        /// <param name="userId">
        /// The user ID of the reviewer. `null` for items resolved with an API key.
        /// </param>
        /// <param name="name">
        /// The name of the reviewer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponseTopReviewer(
            int reviewCount,
            string? userId,
            string? name)
        {
            this.UserId = userId;
            this.Name = name;
            this.ReviewCount = reviewCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTopReviewer" /> class.
        /// </summary>
        public QueueViewOpenGetStatsResponseTopReviewer()
        {
        }

    }
}