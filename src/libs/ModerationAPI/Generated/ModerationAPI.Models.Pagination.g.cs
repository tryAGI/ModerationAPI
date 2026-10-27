
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Where this page is in the full list.
    /// </summary>
    public sealed partial class Pagination
    {
        /// <summary>
        /// The current page, starting at 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// Number of items per page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageSize { get; set; }

        /// <summary>
        /// Total number of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPages { get; set; }

        /// <summary>
        /// Whether there is a next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        /// <param name="page">
        /// The current page, starting at 1.
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page.
        /// </param>
        /// <param name="total">
        /// Total number of items.
        /// </param>
        /// <param name="totalPages">
        /// Total number of pages.
        /// </param>
        /// <param name="hasMore">
        /// Whether there is a next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Pagination(
            int page,
            int pageSize,
            int total,
            int totalPages,
            bool hasMore)
        {
            this.Page = page;
            this.PageSize = pageSize;
            this.Total = total;
            this.TotalPages = totalPages;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        public Pagination()
        {
        }

    }
}