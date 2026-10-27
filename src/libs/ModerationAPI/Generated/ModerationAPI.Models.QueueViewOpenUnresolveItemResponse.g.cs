
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
        /// `pending` waits for review. `resolved` is reviewed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.QueueViewOpenUnresolveItemResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus Status { get; set; }

        /// <summary>
        /// When the item was unresolved (ISO 8601).
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
        /// `pending` waits for review. `resolved` is reviewed.
        /// </param>
        /// <param name="unresolvedAt">
        /// When the item was unresolved (ISO 8601).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenUnresolveItemResponse(
            bool success,
            global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus status,
            string unresolvedAt)
        {
            this.Success = success;
            this.Status = status;
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