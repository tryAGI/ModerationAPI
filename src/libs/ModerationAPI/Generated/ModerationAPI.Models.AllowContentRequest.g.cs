
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AllowContentRequest
    {
        /// <summary>
        /// Why the action was taken. Saved with the action and sent in the webhook event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The queue the content is reviewed in. Defaults to the project's default queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueId")]
        public string? QueueId { get; set; }

        /// <summary>
        /// The user ID or email of the organization member who made the decision. The action is recorded as theirs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderator")]
        public string? Moderator { get; set; }

        /// <summary>
        /// Record an allow or reject decision as a casebook case. Defaults to true when `moderator` is set, else false. Without `moderator`, the case is recorded as System.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createCasebookCase")]
        public bool? CreateCasebookCase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowContentRequest" /> class.
        /// </summary>
        /// <param name="reason">
        /// Why the action was taken. Saved with the action and sent in the webhook event.
        /// </param>
        /// <param name="queueId">
        /// The queue the content is reviewed in. Defaults to the project's default queue.
        /// </param>
        /// <param name="moderator">
        /// The user ID or email of the organization member who made the decision. The action is recorded as theirs.
        /// </param>
        /// <param name="createCasebookCase">
        /// Record an allow or reject decision as a casebook case. Defaults to true when `moderator` is set, else false. Without `moderator`, the case is recorded as System.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllowContentRequest(
            string? reason,
            string? queueId,
            string? moderator,
            bool? createCasebookCase)
        {
            this.Reason = reason;
            this.QueueId = queueId;
            this.Moderator = moderator;
            this.CreateCasebookCase = createCasebookCase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowContentRequest" /> class.
        /// </summary>
        public AllowContentRequest()
        {
        }

    }
}