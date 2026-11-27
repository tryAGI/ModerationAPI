
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelWordlist
    {
        /// <summary>
        /// The ID of the wordlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordlistId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WordlistId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Whether the channel uses the wordlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// `BLOCK_LIST` flags content that matches. `REQUIRE_LIST` flags content that does not match. `PASS_LIST` never flags, but still returns matches and masks them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ChannelWordlistTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ChannelWordlistType Type { get; set; }

        /// <summary>
        /// The text that replaces a match, for example `***`. Null does not mask.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public string? Mask { get; set; }

        /// <summary>
        /// How close a word must be to match: 1 is an exact match, lower values also match similar words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelWordlist" /> class.
        /// </summary>
        /// <param name="wordlistId">
        /// The ID of the wordlist.
        /// </param>
        /// <param name="key"></param>
        /// <param name="enabled">
        /// Whether the channel uses the wordlist.
        /// </param>
        /// <param name="type">
        /// `BLOCK_LIST` flags content that matches. `REQUIRE_LIST` flags content that does not match. `PASS_LIST` never flags, but still returns matches and masks them.
        /// </param>
        /// <param name="threshold">
        /// How close a word must be to match: 1 is an exact match, lower values also match similar words.
        /// </param>
        /// <param name="name"></param>
        /// <param name="mask">
        /// The text that replaces a match, for example `***`. Null does not mask.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelWordlist(
            string wordlistId,
            string key,
            bool enabled,
            global::ModerationAPI.ChannelWordlistType type,
            double threshold,
            string? name,
            string? mask)
        {
            this.WordlistId = wordlistId ?? throw new global::System.ArgumentNullException(nameof(wordlistId));
            this.Name = name;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Enabled = enabled;
            this.Type = type;
            this.Mask = mask;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelWordlist" /> class.
        /// </summary>
        public ChannelWordlist()
        {
        }

    }
}