
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetItemsResponsePagination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentPage { get; set; }

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
        /// Initializes a new instance of the <see cref="QueueViewOpenGetItemsResponsePagination" /> class.
        /// </summary>
        /// <param name="totalItems"></param>
        /// <param name="totalPages"></param>
        /// <param name="currentPage"></param>
        /// <param name="hasNextPage"></param>
        /// <param name="hasPreviousPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetItemsResponsePagination(
            double totalItems,
            double totalPages,
            double currentPage,
            bool hasNextPage,
            bool hasPreviousPage)
        {
            this.TotalItems = totalItems;
            this.TotalPages = totalPages;
            this.CurrentPage = currentPage;
            this.HasNextPage = hasNextPage;
            this.HasPreviousPage = hasPreviousPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetItemsResponsePagination" /> class.
        /// </summary>
        public QueueViewOpenGetItemsResponsePagination()
        {
        }
    }
}