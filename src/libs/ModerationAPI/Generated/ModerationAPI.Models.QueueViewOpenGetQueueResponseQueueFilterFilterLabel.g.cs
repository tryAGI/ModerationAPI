
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetQueueResponseQueueFilterFilterLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minThreshold")]
        public double? MinThreshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxThreshold")]
        public double? MaxThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponseQueueFilterFilterLabel" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="type"></param>
        /// <param name="minThreshold"></param>
        /// <param name="maxThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetQueueResponseQueueFilterFilterLabel(
            string label,
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType type,
            double? minThreshold,
            double? maxThreshold)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Type = type;
            this.MinThreshold = minThreshold;
            this.MaxThreshold = maxThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetQueueResponseQueueFilterFilterLabel" /> class.
        /// </summary>
        public QueueViewOpenGetQueueResponseQueueFilterFilterLabel()
        {
        }
    }
}