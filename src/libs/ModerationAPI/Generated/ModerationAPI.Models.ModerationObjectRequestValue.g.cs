
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The object you want to analyze.
    /// </summary>
    public sealed partial class ModerationObjectRequestValue
    {
        /// <summary>
        /// The type of the object you want to analyze.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ModerationObjectRequestValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ModerationObjectRequestValueType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.ModerationObjectRequestValueData2> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectRequestValue" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object you want to analyze.
        /// </param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationObjectRequestValue(
            global::ModerationAPI.ModerationObjectRequestValueType type,
            global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.ModerationObjectRequestValueData2> data)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectRequestValue" /> class.
        /// </summary>
        public ModerationObjectRequestValue()
        {
        }
    }
}