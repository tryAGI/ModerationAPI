
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateChannelWordlistsRequestWordlist
    {
        /// <summary>
        /// The ID of the wordlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordlistId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WordlistId { get; set; }

        /// <summary>
        /// True makes the channel use the wordlist. False stops it. The wordlist itself is not deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// `BLOCK_LIST` flags content that matches. `REQUIRE_LIST` flags content that does not match. `PASS_LIST` never flags, but still returns matches and masks them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.UpdateChannelWordlistsRequestWordlistTypeJsonConverter))]
        public global::ModerationAPI.UpdateChannelWordlistsRequestWordlistType? Type { get; set; }

        /// <summary>
        /// The text that replaces a match, for example `***`. Null does not mask.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public string? Mask { get; set; }

        /// <summary>
        /// How close a word must be to match: 1 is an exact match, lower values also match similar words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelWordlistsRequestWordlist" /> class.
        /// </summary>
        /// <param name="wordlistId">
        /// The ID of the wordlist.
        /// </param>
        /// <param name="enabled">
        /// True makes the channel use the wordlist. False stops it. The wordlist itself is not deleted.
        /// </param>
        /// <param name="type">
        /// `BLOCK_LIST` flags content that matches. `REQUIRE_LIST` flags content that does not match. `PASS_LIST` never flags, but still returns matches and masks them.
        /// </param>
        /// <param name="mask">
        /// The text that replaces a match, for example `***`. Null does not mask.
        /// </param>
        /// <param name="threshold">
        /// How close a word must be to match: 1 is an exact match, lower values also match similar words.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelWordlistsRequestWordlist(
            string wordlistId,
            bool enabled,
            global::ModerationAPI.UpdateChannelWordlistsRequestWordlistType? type,
            string? mask,
            double? threshold)
        {
            this.WordlistId = wordlistId ?? throw new global::System.ArgumentNullException(nameof(wordlistId));
            this.Enabled = enabled;
            this.Type = type;
            this.Mask = mask;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelWordlistsRequestWordlist" /> class.
        /// </summary>
        public UpdateChannelWordlistsRequestWordlist()
        {
        }

    }
}