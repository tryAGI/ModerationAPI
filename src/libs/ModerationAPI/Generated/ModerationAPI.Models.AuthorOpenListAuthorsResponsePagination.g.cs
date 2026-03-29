
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorOpenListAuthorsResponsePagination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageNumber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNextPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasPreviousPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPreviousPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenListAuthorsResponsePagination" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="hasNextPage"></param>
        /// <param name="hasPreviousPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorOpenListAuthorsResponsePagination(
            double total,
            double pageSize,
            double pageNumber,
            bool hasNextPage,
            bool hasPreviousPage)
        {
            this.Total = total;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
            this.HasNextPage = hasNextPage;
            this.HasPreviousPage = hasPreviousPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenListAuthorsResponsePagination" /> class.
        /// </summary>
        public AuthorOpenListAuthorsResponsePagination()
        {
        }
    }
}