
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Audio chunk for one track.
    /// </summary>
    public sealed partial class VoiceMediaFrame
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceMediaFrameEventJsonConverter))]
        public global::ModerationAPI.VoiceMediaFrameEvent Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.VoiceMediaFrameMedia Media { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMediaFrame" /> class.
        /// </summary>
        /// <param name="media"></param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceMediaFrame(
            global::ModerationAPI.VoiceMediaFrameMedia media,
            global::ModerationAPI.VoiceMediaFrameEvent @event)
        {
            this.Event = @event;
            this.Media = media ?? throw new global::System.ArgumentNullException(nameof(media));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceMediaFrame" /> class.
        /// </summary>
        public VoiceMediaFrame()
        {
        }

    }
}