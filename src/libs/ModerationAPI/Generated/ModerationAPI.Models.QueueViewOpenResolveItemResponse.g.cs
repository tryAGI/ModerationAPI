
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenResolveItemResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Timestamp when the item was resolved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResolvedAt { get; set; }

        /// <summary>
        /// Optional comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenResolveItemResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="resolvedAt">
        /// Timestamp when the item was resolved
        /// </param>
        /// <param name="comment">
        /// Optional comment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenResolveItemResponse(
            bool success,
            string resolvedAt,
            string? comment)
        {
            this.Success = success;
            this.ResolvedAt = resolvedAt ?? throw new global::System.ArgumentNullException(nameof(resolvedAt));
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenResolveItemResponse" /> class.
        /// </summary>
        public QueueViewOpenResolveItemResponse()
        {
        }
    }
}