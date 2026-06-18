
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Ends the call gracefully (or just disconnect).
    /// </summary>
    public sealed partial class VoiceStopFrame
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceStopFrameEventJsonConverter))]
        public global::ModerationAPI.VoiceStopFrameEvent Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStopFrame" /> class.
        /// </summary>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceStopFrame(
            global::ModerationAPI.VoiceStopFrameEvent @event)
        {
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStopFrame" /> class.
        /// </summary>
        public VoiceStopFrame()
        {
        }

    }
}