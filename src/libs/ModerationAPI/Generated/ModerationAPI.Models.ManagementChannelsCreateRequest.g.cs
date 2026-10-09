
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementChannelsCreateRequest
    {
        /// <summary>
        /// The channel's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The key you pass as `channel` when you moderate content. Defaults to the name in lowercase with dashes. Must be unique in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The channel's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The kind of content the channel moderates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ManagementChannelsCreateRequestContentTypeJsonConverter))]
        public global::ModerationAPI.ManagementChannelsCreateRequestContentType? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementChannelsCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The channel's name.
        /// </param>
        /// <param name="key">
        /// The key you pass as `channel` when you moderate content. Defaults to the name in lowercase with dashes. Must be unique in the project.
        /// </param>
        /// <param name="description">
        /// The channel's description.
        /// </param>
        /// <param name="contentType">
        /// The kind of content the channel moderates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementChannelsCreateRequest(
            string name,
            string? key,
            string? description,
            global::ModerationAPI.ManagementChannelsCreateRequestContentType? contentType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Key = key;
            this.Description = description;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementChannelsCreateRequest" /> class.
        /// </summary>
        public ManagementChannelsCreateRequest()
        {
        }

    }
}