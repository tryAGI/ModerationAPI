
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateWordlistRequest
    {
        /// <summary>
        /// Name of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Key of the wordlist. Default: made from the name. If the key is already in use, a suffix is added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Description of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Words to add to the wordlist. Words are converted to lowercase. Duplicate and empty words are ignored. Maximum 5000 words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<string>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWordlistRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the wordlist
        /// </param>
        /// <param name="key">
        /// Key of the wordlist. Default: made from the name. If the key is already in use, a suffix is added.
        /// </param>
        /// <param name="description">
        /// Description of the wordlist
        /// </param>
        /// <param name="words">
        /// Words to add to the wordlist. Words are converted to lowercase. Duplicate and empty words are ignored. Maximum 5000 words.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWordlistRequest(
            string name,
            string? key,
            string? description,
            global::System.Collections.Generic.IList<string>? words)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Key = key;
            this.Description = description;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWordlistRequest" /> class.
        /// </summary>
        public CreateWordlistRequest()
        {
        }

    }
}