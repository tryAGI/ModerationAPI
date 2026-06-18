
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// A finalized utterance with its moderation result. The evaluation/recommendation/policies match the standard moderation response.
    /// </summary>
    public sealed partial class VoiceUtteranceFinal
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int V { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceUtteranceFinalEventJsonConverter))]
        public global::ModerationAPI.VoiceUtteranceFinalEvent Event { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("track")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.VoiceUtteranceFinalTrackJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.VoiceUtteranceFinalTrack Track { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        public string? AuthorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startMs")]
        public int? StartMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endMs")]
        public int? EndMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sttConfidence")]
        public double? SttConfidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        public object? Evaluation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.VoiceUtteranceFinalRecommendation Recommendation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<object>? Policies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUtteranceFinal" /> class.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="contentId"></param>
        /// <param name="track"></param>
        /// <param name="text"></param>
        /// <param name="recommendation"></param>
        /// <param name="event"></param>
        /// <param name="conversationId"></param>
        /// <param name="authorId"></param>
        /// <param name="startMs"></param>
        /// <param name="endMs"></param>
        /// <param name="sttConfidence"></param>
        /// <param name="evaluation"></param>
        /// <param name="policies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceUtteranceFinal(
            int v,
            string contentId,
            global::ModerationAPI.VoiceUtteranceFinalTrack track,
            string text,
            global::ModerationAPI.VoiceUtteranceFinalRecommendation recommendation,
            global::ModerationAPI.VoiceUtteranceFinalEvent @event,
            string? conversationId,
            string? authorId,
            int? startMs,
            int? endMs,
            double? sttConfidence,
            object? evaluation,
            global::System.Collections.Generic.IList<object>? policies)
        {
            this.V = v;
            this.Event = @event;
            this.ConversationId = conversationId;
            this.ContentId = contentId ?? throw new global::System.ArgumentNullException(nameof(contentId));
            this.Track = track;
            this.AuthorId = authorId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.StartMs = startMs;
            this.EndMs = endMs;
            this.SttConfidence = sttConfidence;
            this.Evaluation = evaluation;
            this.Recommendation = recommendation ?? throw new global::System.ArgumentNullException(nameof(recommendation));
            this.Policies = policies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceUtteranceFinal" /> class.
        /// </summary>
        public VoiceUtteranceFinal()
        {
        }

    }
}