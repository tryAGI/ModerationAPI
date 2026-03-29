
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenUnresolveItemResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// New status of the item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Timestamp when the item was unresolved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unresolvedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnresolvedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenUnresolveItemResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="status">
        /// New status of the item
        /// </param>
        /// <param name="unresolvedAt">
        /// Timestamp when the item was unresolved
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenUnresolveItemResponse(
            bool success,
            string status,
            string unresolvedAt)
        {
            this.Success = success;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.UnresolvedAt = unresolvedAt ?? throw new global::System.ArgumentNullException(nameof(unresolvedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenUnresolveItemResponse" /> class.
        /// </summary>
        public QueueViewOpenUnresolveItemResponse()
        {
        }
    }
}