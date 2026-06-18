
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceStartFrameMediaFormat
    {
        /// <summary>
        /// audio/x-mulaw (PCMU), audio/x-alaw (PCMA), audio/l16 (linear16), or a common container (wav/mp3/ogg/flac).<br/>
        /// Example: audio/x-mulaw
        /// </summary>
        /// <example>audio/x-mulaw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Encoding { get; set; }

        /// <summary>
        /// Example: 8000
        /// </summary>
        /// <example>8000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStartFrameMediaFormat" /> class.
        /// </summary>
        /// <param name="encoding">
        /// audio/x-mulaw (PCMU), audio/x-alaw (PCMA), audio/l16 (linear16), or a common container (wav/mp3/ogg/flac).<br/>
        /// Example: audio/x-mulaw
        /// </param>
        /// <param name="sampleRate">
        /// Example: 8000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceStartFrameMediaFormat(
            string encoding,
            int sampleRate)
        {
            this.Encoding = encoding ?? throw new global::System.ArgumentNullException(nameof(encoding));
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStartFrameMediaFormat" /> class.
        /// </summary>
        public VoiceStartFrameMediaFormat()
        {
        }

    }
}