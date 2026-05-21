
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The transcribed text from audio content. Only present when audio moderation is used and transcript inclusion is enabled on the channel.
    /// </summary>
    public sealed partial class NewModerateModerateResponseContentTranscript
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}