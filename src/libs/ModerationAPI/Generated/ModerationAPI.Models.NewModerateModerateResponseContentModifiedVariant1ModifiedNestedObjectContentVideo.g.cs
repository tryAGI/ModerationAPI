
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Video
    /// </summary>
    public sealed partial class NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"video"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "video";

        /// <summary>
        /// A public URL of the video content
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
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo" /> class.
        /// </summary>
        /// <param name="url">
        /// A public URL of the video content
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo(
            string url,
            string type = "video")
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo" /> class.
        /// </summary>
        public NewModerateModerateResponseContentModifiedVariant1ModifiedNestedObjectContentVideo()
        {
        }
    }
}