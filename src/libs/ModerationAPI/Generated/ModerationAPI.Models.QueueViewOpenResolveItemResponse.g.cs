
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
        /// When the item was resolved (ISO 8601).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResolvedAt { get; set; }

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
        /// When the item was resolved (ISO 8601).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenResolveItemResponse(
            bool success,
            string resolvedAt)
        {
            this.Success = success;
            this.ResolvedAt = resolvedAt ?? throw new global::System.ArgumentNullException(nameof(resolvedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenResolveItemResponse" /> class.
        /// </summary>
        public QueueViewOpenResolveItemResponse()
        {
        }

    }
}