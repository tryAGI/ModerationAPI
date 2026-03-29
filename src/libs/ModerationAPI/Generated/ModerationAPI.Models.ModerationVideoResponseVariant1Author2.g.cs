
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationVideoResponseVariant1Author2
    {
        /// <summary>
        /// Author ID in Moderation API
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The author's ID from your system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Block or suspension details, if applicable. Null if the author is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block")]
        public global::ModerationAPI.ModerationVideoResponseVariant1AuthorBlock2? Block { get; set; }

        /// <summary>
        /// Current author status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ModerationVideoResponseVariant1AuthorStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ModerationVideoResponseVariant1AuthorStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trust_level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ModerationVideoResponseVariant1AuthorTrustLevel TrustLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationVideoResponseVariant1Author2" /> class.
        /// </summary>
        /// <param name="id">
        /// Author ID in Moderation API
        /// </param>
        /// <param name="status">
        /// Current author status
        /// </param>
        /// <param name="trustLevel"></param>
        /// <param name="externalId">
        /// The author's ID from your system
        /// </param>
        /// <param name="block">
        /// Block or suspension details, if applicable. Null if the author is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationVideoResponseVariant1Author2(
            string id,
            global::ModerationAPI.ModerationVideoResponseVariant1AuthorStatus status,
            global::ModerationAPI.ModerationVideoResponseVariant1AuthorTrustLevel trustLevel,
            string? externalId,
            global::ModerationAPI.ModerationVideoResponseVariant1AuthorBlock2? block)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ExternalId = externalId;
            this.Block = block;
            this.Status = status;
            this.TrustLevel = trustLevel ?? throw new global::System.ArgumentNullException(nameof(trustLevel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationVideoResponseVariant1Author2" /> class.
        /// </summary>
        public ModerationVideoResponseVariant1Author2()
        {
        }
    }
}