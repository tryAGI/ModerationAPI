
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Image
    /// </summary>
    public sealed partial class NewModerateModerateRequestContentImage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image";

        /// <summary>
        /// A public URL of the image content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Base64-encoded image data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestContentImage" /> class.
        /// </summary>
        /// <param name="url">
        /// A public URL of the image content
        /// </param>
        /// <param name="data">
        /// Base64-encoded image data
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestContentImage(
            string? url,
            string? data,
            string type = "image")
        {
            this.Type = type;
            this.Url = url;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestContentImage" /> class.
        /// </summary>
        public NewModerateModerateRequestContentImage()
        {
        }
    }
}