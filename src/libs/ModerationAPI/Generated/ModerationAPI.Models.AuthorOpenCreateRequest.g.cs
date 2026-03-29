
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorOpenCreateRequest
    {
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
        /// Additional metadata provided by your system. We recommend including any relevant information that may assist in the moderation process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::ModerationAPI.AuthorOpenCreateRequestMetadata? Metadata { get; set; }

        /// <summary>
        /// Timestamp when author first appeared
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen")]
        public double? FirstSeen { get; set; }

        /// <summary>
        /// Timestamp of last activity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen")]
        public double? LastSeen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual_trust_level")]
        public double? ManualTrustLevel { get; set; }

        /// <summary>
        /// External ID of the user, typically the ID of the author in your database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenCreateRequest" /> class.
        /// </summary>
        /// <param name="externalId">
        /// External ID of the user, typically the ID of the author in your database.
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
        /// <param name="metadata">
        /// Additional metadata provided by your system. We recommend including any relevant information that may assist in the moderation process.
        /// </param>
        /// <param name="firstSeen">
        /// Timestamp when author first appeared
        /// </param>
        /// <param name="lastSeen">
        /// Timestamp of last activity
        /// </param>
        /// <param name="manualTrustLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorOpenCreateRequest(
            string externalId,
            string? profilePicture,
            string? externalLink,
            string? name,
            string? email,
            global::ModerationAPI.AuthorOpenCreateRequestMetadata? metadata,
            double? firstSeen,
            double? lastSeen,
            double? manualTrustLevel)
        {
            this.ProfilePicture = profilePicture;
            this.ExternalLink = externalLink;
            this.Name = name;
            this.Email = email;
            this.Metadata = metadata;
            this.FirstSeen = firstSeen;
            this.LastSeen = lastSeen;
            this.ManualTrustLevel = manualTrustLevel;
            this.ExternalId = externalId ?? throw new global::System.ArgumentNullException(nameof(externalId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenCreateRequest" /> class.
        /// </summary>
        public AuthorOpenCreateRequest()
        {
        }
    }
}