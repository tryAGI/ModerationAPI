
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Audio
    /// </summary>
    public sealed partial class NewModerateModerateResponseContentModifiedVariant1Audio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "audio";

        /// <summary>
        /// The URL of the audio content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseContentModifiedVariant1Audio" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the audio content
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseContentModifiedVariant1Audio(
            string url,
            string type = "audio")
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseContentModifiedVariant1Audio" /> class.
        /// </summary>
        public NewModerateModerateResponseContentModifiedVariant1Audio()
        {
        }
    }
}