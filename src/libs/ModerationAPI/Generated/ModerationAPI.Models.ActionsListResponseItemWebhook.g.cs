
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListResponseItemWebhook
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
        /// The ID of the moderation action to trigger the webhook on. Only used for moderation action webhooks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderationActionId")]
        public string? ModerationActionId { get; set; }

        /// <summary>
        /// The ID of the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListResponseItemWebhook" /> class.
        /// </summary>
        /// <param name="name">
        /// The webhook's name, used to identify it in the dashboard
        /// </param>
        /// <param name="url">
        /// The webhook's URL. We'll call this URL when the event occurs.
        /// </param>
        /// <param name="id">
        /// The ID of the webhook.
        /// </param>
        /// <param name="description">
        /// The webhook's description
        /// </param>
        /// <param name="moderationActionId">
        /// The ID of the moderation action to trigger the webhook on. Only used for moderation action webhooks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsListResponseItemWebhook(
            string name,
            string url,
            string id,
            string? description,
            string? moderationActionId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ModerationActionId = moderationActionId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListResponseItemWebhook" /> class.
        /// </summary>
        public ActionsListResponseItemWebhook()
        {
        }
    }
}