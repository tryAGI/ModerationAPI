
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SuspendAuthorRequest
    {
        /// <summary>
        /// Why the action was taken. Saved with the action and sent in the webhook event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// How long the suspension lasts, in milliseconds. Defaults to 24 hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuspendAuthorRequest" /> class.
        /// </summary>
        /// <param name="reason">
        /// Why the action was taken. Saved with the action and sent in the webhook event.
        /// </param>
        /// <param name="duration">
        /// How long the suspension lasts, in milliseconds. Defaults to 24 hours.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuspendAuthorRequest(
            string? reason,
            double? duration)
        {
            this.Reason = reason;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuspendAuthorRequest" /> class.
        /// </summary>
        public SuspendAuthorRequest()
        {
        }

    }
}