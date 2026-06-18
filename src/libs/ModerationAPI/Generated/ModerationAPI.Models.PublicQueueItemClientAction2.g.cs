
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// A recommendation from your own client-side flagging.
    /// </summary>
    public sealed partial class PublicQueueItemClientAction2
    {
        /// <summary>
        /// Your recommendation for the content: allow, review, or reject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.PublicQueueItemClientActionAction Action { get; set; }

        /// <summary>
        /// How your recommendation combines with ours. Defaults to 'escalate', which only applies it when stricter than ours; 'override' replaces ours outright.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.PublicQueueItemClientActionBehaviorJsonConverter))]
        public global::ModerationAPI.PublicQueueItemClientActionBehavior? Behavior { get; set; }

        /// <summary>
        /// Where your recommendation came from, e.g. "banned-ip".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// A human-readable explanation for your recommendation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemClientAction2" /> class.
        /// </summary>
        /// <param name="action">
        /// Your recommendation for the content: allow, review, or reject.
        /// </param>
        /// <param name="behavior">
        /// How your recommendation combines with ours. Defaults to 'escalate', which only applies it when stricter than ours; 'override' replaces ours outright.
        /// </param>
        /// <param name="source">
        /// Where your recommendation came from, e.g. "banned-ip".
        /// </param>
        /// <param name="reason">
        /// A human-readable explanation for your recommendation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicQueueItemClientAction2(
            global::ModerationAPI.PublicQueueItemClientActionAction action,
            global::ModerationAPI.PublicQueueItemClientActionBehavior? behavior,
            string? source,
            string? reason)
        {
            this.Action = action;
            this.Behavior = behavior;
            this.Source = source;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemClientAction2" /> class.
        /// </summary>
        public PublicQueueItemClientAction2()
        {
        }

    }
}