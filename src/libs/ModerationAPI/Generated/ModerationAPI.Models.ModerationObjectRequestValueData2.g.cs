
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationObjectRequestValueData2
    {
        /// <summary>
        /// The type of content (e.g., "text", "image", "video")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ModerationObjectRequestValueDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ModerationObjectRequestValueDataType Type { get; set; }

        /// <summary>
        /// Optional array of specific model IDs to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelIds")]
        public global::System.Collections.Generic.IList<string>? ModelIds { get; set; }

        /// <summary>
        /// The content to analyze
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectRequestValueData2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content (e.g., "text", "image", "video")
        /// </param>
        /// <param name="value">
        /// The content to analyze
        /// </param>
        /// <param name="modelIds">
        /// Optional array of specific model IDs to use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationObjectRequestValueData2(
            global::ModerationAPI.ModerationObjectRequestValueDataType type,
            string value,
            global::System.Collections.Generic.IList<string>? modelIds)
        {
            this.Type = type;
            this.ModelIds = modelIds;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectRequestValueData2" /> class.
        /// </summary>
        public ModerationObjectRequestValueData2()
        {
        }
    }
}