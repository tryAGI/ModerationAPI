
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Arbitrary JSON attached to the conversation. Stored as-is and not interpreted by moderation.
    /// </summary>
    public sealed partial class VoiceStartFrameMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}