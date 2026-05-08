
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// High-level content type (e.g. message, post, comment). Defaults to the channel's configured content type but can be overridden per request via the moderation API `type` field.
    /// </summary>
    public sealed partial class PublicQueueItemMetaType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}