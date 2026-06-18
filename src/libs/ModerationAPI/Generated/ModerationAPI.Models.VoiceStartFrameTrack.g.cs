
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceStartFrameTrack
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceStartFrameTrackNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.VoiceStartFrameTrackName Name { get; set; }

        /// <summary>
        /// Your identifier for the speaker on this track.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        public string? AuthorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStartFrameTrack" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="authorId">
        /// Your identifier for the speaker on this track.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceStartFrameTrack(
            global::ModerationAPI.VoiceStartFrameTrackName name,
            string? authorId)
        {
            this.Name = name;
            this.AuthorId = authorId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStartFrameTrack" /> class.
        /// </summary>
        public VoiceStartFrameTrack()
        {
        }

    }
}