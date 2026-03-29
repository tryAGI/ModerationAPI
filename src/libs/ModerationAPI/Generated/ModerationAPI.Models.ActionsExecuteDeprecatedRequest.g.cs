
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsExecuteDeprecatedRequest
    {
        /// <summary>
        /// The IDs of the content items to perform the action on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentIds")]
        public global::System.Collections.Generic.IList<string>? ContentIds { get; set; }

        /// <summary>
        /// IDs of the authors to apply the action to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorIds")]
        public global::System.Collections.Generic.IList<string>? AuthorIds { get; set; }

        /// <summary>
        /// The ID of the queue the action was performed from if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueId")]
        public string? QueueId { get; set; }

        /// <summary>
        /// The value of the action. Useful to set a reason for the action etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsExecuteDeprecatedRequest" /> class.
        /// </summary>
        /// <param name="contentIds">
        /// The IDs of the content items to perform the action on.
        /// </param>
        /// <param name="authorIds">
        /// IDs of the authors to apply the action to
        /// </param>
        /// <param name="queueId">
        /// The ID of the queue the action was performed from if any.
        /// </param>
        /// <param name="value">
        /// The value of the action. Useful to set a reason for the action etc.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsExecuteDeprecatedRequest(
            global::System.Collections.Generic.IList<string>? contentIds,
            global::System.Collections.Generic.IList<string>? authorIds,
            string? queueId,
            string? value)
        {
            this.ContentIds = contentIds;
            this.AuthorIds = authorIds;
            this.QueueId = queueId;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsExecuteDeprecatedRequest" /> class.
        /// </summary>
        public ActionsExecuteDeprecatedRequest()
        {
        }
    }
}