
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordlistUpdateResponse
    {
        /// <summary>
        /// ID of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Words in the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Words { get; set; }

        /// <summary>
        /// Creation date of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// ID of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Strict mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistUpdateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the wordlist
        /// </param>
        /// <param name="words">
        /// Words in the wordlist
        /// </param>
        /// <param name="createdAt">
        /// Creation date of the wordlist
        /// </param>
        /// <param name="organizationId">
        /// ID of the organization
        /// </param>
        /// <param name="strict">
        /// Strict mode
        /// </param>
        /// <param name="name"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordlistUpdateResponse(
            string id,
            global::System.Collections.Generic.IList<string> words,
            string createdAt,
            string organizationId,
            bool strict,
            string? name,
            string? userId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.UserId = userId;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistUpdateResponse" /> class.
        /// </summary>
        public WordlistUpdateResponse()
        {
        }
    }
}