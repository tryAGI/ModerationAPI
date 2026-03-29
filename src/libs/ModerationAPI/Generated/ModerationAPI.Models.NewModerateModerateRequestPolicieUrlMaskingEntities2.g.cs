
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieUrlMaskingEntities2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieUrlMaskingEntitiesIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntitiesId Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldMask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ShouldMask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public string? Mask { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUrlMaskingEntities2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enable"></param>
        /// <param name="flag"></param>
        /// <param name="shouldMask"></param>
        /// <param name="mask"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPolicieUrlMaskingEntities2(
            global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntitiesId id,
            bool enable,
            bool flag,
            bool shouldMask,
            string? mask)
        {
            this.Id = id;
            this.Enable = enable;
            this.Flag = flag;
            this.ShouldMask = shouldMask;
            this.Mask = mask;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUrlMaskingEntities2" /> class.
        /// </summary>
        public NewModerateModerateRequestPolicieUrlMaskingEntities2()
        {
        }
    }
}