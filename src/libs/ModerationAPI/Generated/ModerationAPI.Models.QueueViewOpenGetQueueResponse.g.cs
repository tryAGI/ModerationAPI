
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetQueueResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.QueueViewOpenGetQueueResponseQueue Queue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponse" /> class.
        /// </summary>
        /// <param name="queue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetQueueResponse(
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueue queue)
        {
            this.Queue = queue ?? throw new global::System.ArgumentNullException(nameof(queue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponse" /> class.
        /// </summary>
        public QueueViewOpenGetQueueResponse()
        {
        }
    }
}