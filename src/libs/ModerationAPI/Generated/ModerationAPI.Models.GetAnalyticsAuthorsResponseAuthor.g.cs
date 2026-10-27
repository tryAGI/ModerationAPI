
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsAuthorsResponseAuthor
    {
        /// <summary>
        /// The author ID from your system. Use it with the authors endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthorId { get; set; }

        /// <summary>
        /// The author name, if known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Flagged requests from this author in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Flagged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsAuthorsResponseAuthor" /> class.
        /// </summary>
        /// <param name="authorId">
        /// The author ID from your system. Use it with the authors endpoints.
        /// </param>
        /// <param name="flagged">
        /// Flagged requests from this author in the window.
        /// </param>
        /// <param name="name">
        /// The author name, if known.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsAuthorsResponseAuthor(
            string authorId,
            int flagged,
            string? name)
        {
            this.AuthorId = authorId ?? throw new global::System.ArgumentNullException(nameof(authorId));
            this.Name = name;
            this.Flagged = flagged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsAuthorsResponseAuthor" /> class.
        /// </summary>
        public GetAnalyticsAuthorsResponseAuthor()
        {
        }

    }
}