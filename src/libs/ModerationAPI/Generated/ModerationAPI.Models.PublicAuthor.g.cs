
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicAuthor
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
        /// URL of the author's profile picture
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_picture")]
        public string? ProfilePicture { get; set; }

        /// <summary>
        /// URL of the author's external profile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_link")]
        public string? ExternalLink { get; set; }

        /// <summary>
        /// Author name or identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Author email address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The author's company or organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Timestamp when author first appeared
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FirstSeen { get; set; }

        /// <summary>
        /// Timestamp of last activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LastSeen { get; set; }

        /// <summary>
        /// Timestamp of last incident
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_incident")]
        public double? LastIncident { get; set; }

        /// <summary>
        /// Current author status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.PublicAuthorStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.PublicAuthorStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trust_level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.PublicAuthorTrustLevel TrustLevel { get; set; }

        /// <summary>
        /// Block or suspension details, if applicable. Null if the author is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block")]
        public global::ModerationAPI.PublicAuthorBlock2? Block { get; set; }

        /// <summary>
        /// Risk assessment details, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("risk_evaluation")]
        public global::ModerationAPI.PublicAuthorRiskEvaluation2? RiskEvaluation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.PublicAuthorMetrics Metrics { get; set; }

        /// <summary>
        /// Additional metadata provided by your system. We recommend including any relevant information that may assist in the moderation process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.PublicAuthorMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAuthor" /> class.
        /// </summary>
        /// <param name="id">
        /// Author ID in Moderation API
        /// </param>
        /// <param name="firstSeen">
        /// Timestamp when author first appeared
        /// </param>
        /// <param name="lastSeen">
        /// Timestamp of last activity
        /// </param>
        /// <param name="status">
        /// Current author status
        /// </param>
        /// <param name="trustLevel"></param>
        /// <param name="metrics"></param>
        /// <param name="metadata">
        /// Additional metadata provided by your system. We recommend including any relevant information that may assist in the moderation process.
        /// </param>
        /// <param name="externalId">
        /// The author's ID from your system
        /// </param>
        /// <param name="profilePicture">
        /// URL of the author's profile picture
        /// </param>
        /// <param name="externalLink">
        /// URL of the author's external profile
        /// </param>
        /// <param name="name">
        /// Author name or identifier
        /// </param>
        /// <param name="email">
        /// Author email address
        /// </param>
        /// <param name="company">
        /// The author's company or organization
        /// </param>
        /// <param name="lastIncident">
        /// Timestamp of last incident
        /// </param>
        /// <param name="block">
        /// Block or suspension details, if applicable. Null if the author is enabled.
        /// </param>
        /// <param name="riskEvaluation">
        /// Risk assessment details, if available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAuthor(
            string id,
            double firstSeen,
            double lastSeen,
            global::ModerationAPI.PublicAuthorStatus status,
            global::ModerationAPI.PublicAuthorTrustLevel trustLevel,
            global::ModerationAPI.PublicAuthorMetrics metrics,
            global::ModerationAPI.PublicAuthorMetadata metadata,
            string? externalId,
            string? profilePicture,
            string? externalLink,
            string? name,
            string? email,
            string? company,
            double? lastIncident,
            global::ModerationAPI.PublicAuthorBlock2? block,
            global::ModerationAPI.PublicAuthorRiskEvaluation2? riskEvaluation)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ExternalId = externalId;
            this.ProfilePicture = profilePicture;
            this.ExternalLink = externalLink;
            this.Name = name;
            this.Email = email;
            this.Company = company;
            this.FirstSeen = firstSeen;
            this.LastSeen = lastSeen;
            this.LastIncident = lastIncident;
            this.Status = status;
            this.TrustLevel = trustLevel ?? throw new global::System.ArgumentNullException(nameof(trustLevel));
            this.Block = block;
            this.RiskEvaluation = riskEvaluation;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAuthor" /> class.
        /// </summary>
        public PublicAuthor()
        {
        }
    }
}