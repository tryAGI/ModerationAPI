
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Embedding status details
    /// </summary>
    public sealed partial class WordlistWordlistEmbeddingStatusResponse
    {
        /// <summary>
        /// Percentage of words that have been embedded (0-100)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Progress { get; set; }

        /// <summary>
        /// Total number of words in the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalWords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalWords { get; set; }

        /// <summary>
        /// Number of words still waiting to be embedded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remainingWords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RemainingWords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistWordlistEmbeddingStatusResponse" /> class.
        /// </summary>
        /// <param name="progress">
        /// Percentage of words that have been embedded (0-100)
        /// </param>
        /// <param name="totalWords">
        /// Total number of words in the wordlist
        /// </param>
        /// <param name="remainingWords">
        /// Number of words still waiting to be embedded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordlistWordlistEmbeddingStatusResponse(
            double progress,
            double totalWords,
            double remainingWords)
        {
            this.Progress = progress;
            this.TotalWords = totalWords;
            this.RemainingWords = remainingWords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistWordlistEmbeddingStatusResponse" /> class.
        /// </summary>
        public WordlistWordlistEmbeddingStatusResponse()
        {
        }
    }
}