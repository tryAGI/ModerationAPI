
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UnblockAuthorRequest
    {
        /// <summary>
        /// Why the action was taken. Saved with the action and sent in the webhook event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnblockAuthorRequest" /> class.
        /// </summary>
        /// <param name="reason">
        /// Why the action was taken. Saved with the action and sent in the webhook event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnblockAuthorRequest(
            string? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnblockAuthorRequest" /> class.
        /// </summary>
        public UnblockAuthorRequest()
        {
        }

    }
}