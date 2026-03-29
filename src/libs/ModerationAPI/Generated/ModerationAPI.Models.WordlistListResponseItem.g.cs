
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordlistListResponseItem
    {
        /// <summary>
        /// Unique identifier of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// When the wordlist was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// User who created the wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistListResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the wordlist
        /// </param>
        /// <param name="name">
        /// Name of the wordlist
        /// </param>
        /// <param name="description">
        /// Description of the wordlist
        /// </param>
        /// <param name="createdAt">
        /// When the wordlist was created
        /// </param>
        /// <param name="userId">
        /// User who created the wordlist
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WordlistListResponseItem(
            string id,
            string? name,
            string? description,
            string? createdAt,
            string? userId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordlistListResponseItem" /> class.
        /// </summary>
        public WordlistListResponseItem()
        {
        }
    }
}