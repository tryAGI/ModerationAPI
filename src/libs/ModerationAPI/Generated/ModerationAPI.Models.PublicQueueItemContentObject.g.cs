
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Object
    /// </summary>
    public sealed partial class PublicQueueItemContentObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"object"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "object";

        /// <summary>
        /// Values in the object. Can be mixed content types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemContentObject" /> class.
        /// </summary>
        /// <param name="data">
        /// Values in the object. Can be mixed content types.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicQueueItemContentObject(
            global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.PublicQueueItemContentObjectDataText, global::ModerationAPI.PublicQueueItemContentObjectDataImage, global::ModerationAPI.PublicQueueItemContentObjectDataVideo, global::ModerationAPI.PublicQueueItemContentObjectDataAudio>> data,
            string type = "object")
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemContentObject" /> class.
        /// </summary>
        public PublicQueueItemContentObject()
        {
        }
    }
}