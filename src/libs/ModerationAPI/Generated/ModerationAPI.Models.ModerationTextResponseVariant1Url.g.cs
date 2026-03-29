
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The url entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/url
    /// </summary>
    public sealed partial class ModerationTextResponseVariant1Url
    {
        /// <summary>
        /// The detection mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ModerationTextResponseVariant1UrlModeJsonConverter))]
        public global::ModerationAPI.ModerationTextResponseVariant1UrlMode? Mode { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1Url" /> class.
        /// </summary>
        /// <param name="mode">
        /// The detection mode.
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
        public ModerationTextResponseVariant1Url(
            global::ModerationAPI.ModerationTextResponseVariant1UrlMode? mode,
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1Url" /> class.
        /// </summary>
        public ModerationTextResponseVariant1Url()
        {
        }
    }
}