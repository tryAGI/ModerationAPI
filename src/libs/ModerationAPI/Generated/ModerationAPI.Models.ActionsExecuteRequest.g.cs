
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Input parameters
    /// </summary>
    public sealed partial class ActionsExecuteRequest
    {
        /// <summary>
        /// ID or key of the action to execute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionKey { get; set; }

        /// <summary>
        /// IDs of the content items to apply the action to. Provide this or authorIds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentIds")]
        public global::System.Collections.Generic.IList<string>? ContentIds { get; set; }

        /// <summary>
        /// IDs of the authors to apply the action to. Provide this or contentIds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorIds")]
        public global::System.Collections.Generic.IList<string>? AuthorIds { get; set; }

        /// <summary>
        /// Optional value to provide with the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Optional queue ID if the action is queue-specific
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueId")]
        public string? QueueId { get; set; }

        /// <summary>
        /// Optional duration in milliseconds for actions with timeouts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsExecuteRequest" /> class.
        /// </summary>
        /// <param name="actionKey">
        /// ID or key of the action to execute
        /// </param>
        /// <param name="contentIds">
        /// IDs of the content items to apply the action to. Provide this or authorIds.
        /// </param>
        /// <param name="authorIds">
        /// IDs of the authors to apply the action to. Provide this or contentIds.
        /// </param>
        /// <param name="value">
        /// Optional value to provide with the action
        /// </param>
        /// <param name="queueId">
        /// Optional queue ID if the action is queue-specific
        /// </param>
        /// <param name="duration">
        /// Optional duration in milliseconds for actions with timeouts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsExecuteRequest(
            string actionKey,
            global::System.Collections.Generic.IList<string>? contentIds,
            global::System.Collections.Generic.IList<string>? authorIds,
            string? value,
            string? queueId,
            double? duration)
        {
            this.ActionKey = actionKey ?? throw new global::System.ArgumentNullException(nameof(actionKey));
            this.ContentIds = contentIds;
            this.AuthorIds = authorIds;
            this.Value = value;
            this.QueueId = queueId;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsExecuteRequest" /> class.
        /// </summary>
        public ActionsExecuteRequest()
        {
        }
    }
}