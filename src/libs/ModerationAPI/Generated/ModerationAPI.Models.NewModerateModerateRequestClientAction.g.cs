
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// A recommendation from your own client-side flagging (e.g. a banned-IP list or a third-party tool). Feeds the rules engine and can escalate or override the recommended action. Does not change whether our analysis flagged the content.
    /// </summary>
    public sealed partial class NewModerateModerateRequestClientAction
    {
        /// <summary>
        /// Your recommendation for the content: allow, review, or reject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateRequestClientActionAction Action { get; set; }

        /// <summary>
        /// How your recommendation combines with ours. Defaults to 'escalate', which only applies it when stricter than ours; 'override' replaces ours outright.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestClientActionBehaviorJsonConverter))]
        public global::ModerationAPI.NewModerateModerateRequestClientActionBehavior? Behavior { get; set; }

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
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestClientAction" /> class.
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
        public NewModerateModerateRequestClientAction(
            global::ModerationAPI.NewModerateModerateRequestClientActionAction action,
            global::ModerationAPI.NewModerateModerateRequestClientActionBehavior? behavior,
            string? source,
            string? reason)
        {
            this.Action = action;
            this.Behavior = behavior;
            this.Source = source;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestClientAction" /> class.
        /// </summary>
        public NewModerateModerateRequestClientAction()
        {
        }

    }
}