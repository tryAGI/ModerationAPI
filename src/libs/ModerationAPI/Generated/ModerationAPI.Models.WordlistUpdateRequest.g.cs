
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordlistUpdateRequest
    {
        /// <summary>
        /// New name for the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New key for the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// New description for the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// New words for the wordlist. Replace the existing words with these new ones. Duplicate words will be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<string>? Words { get; set; }

        /// <summary>
        /// Deprecated. Now using threshold in project settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the wordlist
        /// </param>
        /// <param name="key">
        /// New key for the wordlist
        /// </param>
        /// <param name="description">
        /// New description for the wordlist
        /// </param>
        /// <param name="words">
        /// New words for the wordlist. Replace the existing words with these new ones. Duplicate words will be ignored.
        /// </param>
        /// <param name="strict">
        /// Deprecated. Now using threshold in project settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordlistUpdateRequest(
            string? name,
            string? key,
            string? description,
            global::System.Collections.Generic.IList<string>? words,
            bool? strict)
        {
            this.Name = name;
            this.Key = key;
            this.Description = description;
            this.Words = words;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistUpdateRequest" /> class.
        /// </summary>
        public WordlistUpdateRequest()
        {
        }
    }
}