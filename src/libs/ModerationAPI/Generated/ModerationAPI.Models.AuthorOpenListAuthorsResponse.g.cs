
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorOpenListAuthorsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.AuthorOpenListAuthorsResponseAuthor> Authors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.AuthorOpenListAuthorsResponsePagination Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenListAuthorsResponse" /> class.
        /// </summary>
        /// <param name="authors"></param>
        /// <param name="pagination"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorOpenListAuthorsResponse(
            global::System.Collections.Generic.IList<global::ModerationAPI.AuthorOpenListAuthorsResponseAuthor> authors,
            global::ModerationAPI.AuthorOpenListAuthorsResponsePagination pagination)
        {
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenListAuthorsResponse" /> class.
        /// </summary>
        public AuthorOpenListAuthorsResponse()
        {
        }
    }
}