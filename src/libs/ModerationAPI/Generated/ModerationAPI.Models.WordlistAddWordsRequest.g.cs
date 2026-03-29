
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordlistAddWordsRequest
    {
        /// <summary>
        /// Array of words to add to the wordlist. Duplicate words will be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistAddWordsRequest" /> class.
        /// </summary>
        /// <param name="words">
        /// Array of words to add to the wordlist. Duplicate words will be ignored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordlistAddWordsRequest(
            global::System.Collections.Generic.IList<string> words)
        {
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistAddWordsRequest" /> class.
        /// </summary>
        public WordlistAddWordsRequest()
        {
        }
    }
}