
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationObjectResponseVariant1Wordlist
    {
        /// <summary>
        /// The flagging mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ModerationObjectResponseVariant1WordlistModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ModerationObjectResponseVariant1WordlistMode Mode { get; set; }

        /// <summary>
        /// Whether a match was found or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("found")]
        public bool? Found { get; set; }

        /// <summary>
        /// The matches of the entity matcher.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<string>? Matches { get; set; }

        /// <summary>
        /// The components of the matcher.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        public object? Components { get; set; }

        /// <summary>
        /// Indicates an error with the matcher.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Indicates a warning from the model, e.g. if the text is too short or long and the model might not be accurate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// Whether the wordlists flagged the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// The name of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The score of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Wordlist" /> class.
        /// </summary>
        /// <param name="mode">
        /// The flagging mode.
        /// </param>
        /// <param name="flagged">
        /// Whether the wordlists flagged the content.
        /// </param>
        /// <param name="name">
        /// The name of the wordlist
        /// </param>
        /// <param name="id">
        /// The ID of the wordlist
        /// </param>
        /// <param name="score">
        /// The score of the wordlist
        /// </param>
        /// <param name="found">
        /// Whether a match was found or not.
        /// </param>
        /// <param name="matches">
        /// The matches of the entity matcher.
        /// </param>
        /// <param name="components">
        /// The components of the matcher.
        /// </param>
        /// <param name="error">
        /// Indicates an error with the matcher.
        /// </param>
        /// <param name="warning">
        /// Indicates a warning from the model, e.g. if the text is too short or long and the model might not be accurate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationObjectResponseVariant1Wordlist(
            global::ModerationAPI.ModerationObjectResponseVariant1WordlistMode mode,
            bool flagged,
            string name,
            string id,
            double score,
            bool? found,
            global::System.Collections.Generic.IList<string>? matches,
            object? components,
            string? error,
            string? warning)
        {
            this.Mode = mode;
            this.Found = found;
            this.Matches = matches;
            this.Components = components;
            this.Error = error;
            this.Warning = warning;
            this.Flagged = flagged;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Wordlist" /> class.
        /// </summary>
        public ModerationObjectResponseVariant1Wordlist()
        {
        }
    }
}