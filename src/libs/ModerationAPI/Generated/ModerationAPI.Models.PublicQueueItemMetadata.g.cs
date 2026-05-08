
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Customer-supplied metadata attached to the content (same shape as the moderation API `metadata` input).
    /// </summary>
    public sealed partial class PublicQueueItemMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}