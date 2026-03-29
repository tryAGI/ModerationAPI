
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationAudioResponseAuthorBlock2
    {
        /// <summary>
        /// The timestamp until which they are blocked if the author is suspended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("until")]
        public double? Until { get; set; }

        /// <summary>
        /// The moderators reason why the author was blocked or suspended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationAudioResponseAuthorBlock2" /> class.
        /// </summary>
        /// <param name="until">
        /// The timestamp until which they are blocked if the author is suspended.
        /// </param>
        /// <param name="reason">
        /// The moderators reason why the author was blocked or suspended.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationAudioResponseAuthorBlock2(
            double? until,
            string? reason)
        {
            this.Until = until;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationAudioResponseAuthorBlock2" /> class.
        /// </summary>
        public ModerationAudioResponseAuthorBlock2()
        {
        }
    }
}