
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordlistRemoveWordsResponse
    {
        /// <summary>
        /// Number of words removed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RemovedCount { get; set; }

        /// <summary>
        /// Total number of words in wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// List of words removed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removedWords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RemovedWords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistRemoveWordsResponse" /> class.
        /// </summary>
        /// <param name="removedCount">
        /// Number of words removed
        /// </param>
        /// <param name="totalCount">
        /// Total number of words in wordlist
        /// </param>
        /// <param name="removedWords">
        /// List of words removed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordlistRemoveWordsResponse(
            double removedCount,
            double totalCount,
            global::System.Collections.Generic.IList<string> removedWords)
        {
            this.RemovedCount = removedCount;
            this.TotalCount = totalCount;
            this.RemovedWords = removedWords ?? throw new global::System.ArgumentNullException(nameof(removedWords));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistRemoveWordsResponse" /> class.
        /// </summary>
        public WordlistRemoveWordsResponse()
        {
        }
    }
}