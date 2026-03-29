
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsUpdateRequestWebhook
    {
        /// <summary>
        /// The webhook's name, used to identify it in the dashboard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The webhook's description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The webhook's URL. We'll call this URL when the event occurs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// ID of an existing webhook or undefined if this is a new webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateRequestWebhook" /> class.
        /// </summary>
        /// <param name="name">
        /// The webhook's name, used to identify it in the dashboard
        /// </param>
        /// <param name="url">
        /// The webhook's URL. We'll call this URL when the event occurs.
        /// </param>
        /// <param name="description">
        /// The webhook's description
        /// </param>
        /// <param name="id">
        /// ID of an existing webhook or undefined if this is a new webhook.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsUpdateRequestWebhook(
            string name,
            string url,
            string? description,
            string? id)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateRequestWebhook" /> class.
        /// </summary>
        public ActionsUpdateRequestWebhook()
        {
        }
    }
}