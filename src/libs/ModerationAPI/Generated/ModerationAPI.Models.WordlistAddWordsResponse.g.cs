
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordlistAddWordsResponse
    {
        /// <summary>
        /// Number of words added
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AddedCount { get; set; }

        /// <summary>
        /// Total number of words in wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// List of words that were added
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedWords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AddedWords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistAddWordsResponse" /> class.
        /// </summary>
        /// <param name="addedCount">
        /// Number of words added
        /// </param>
        /// <param name="totalCount">
        /// Total number of words in wordlist
        /// </param>
        /// <param name="addedWords">
        /// List of words that were added
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordlistAddWordsResponse(
            double addedCount,
            double totalCount,
            global::System.Collections.Generic.IList<string> addedWords)
        {
            this.AddedCount = addedCount;
            this.TotalCount = totalCount;
            this.AddedWords = addedWords ?? throw new global::System.ArgumentNullException(nameof(addedWords));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistAddWordsResponse" /> class.
        /// </summary>
        public WordlistAddWordsResponse()
        {
        }
    }
}