
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksPublicUpdateResponse
    {
        /// <summary>
        /// The ID of the webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The webhook's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The webhook's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The URL we call when a subscribed event occurs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Event types this webhook subscribes to. Empty for legacy v1 webhooks, which subscribe via their single deprecated `type` instead.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateResponseEventType> EventTypes { get; set; }

        /// <summary>
        /// Payload envelope version. V2 is the Stripe-style envelope; V1 is the legacy flat shape and is read-only via this API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.WebhooksPublicUpdateResponsePayloadVersionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion PayloadVersion { get; set; }

        /// <summary>
        /// The date the webhook was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksPublicUpdateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the webhook.
        /// </param>
        /// <param name="name">
        /// The webhook's name.
        /// </param>
        /// <param name="url">
        /// The URL we call when a subscribed event occurs.
        /// </param>
        /// <param name="eventTypes">
        /// Event types this webhook subscribes to. Empty for legacy v1 webhooks, which subscribe via their single deprecated `type` instead.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="payloadVersion">
        /// Payload envelope version. V2 is the Stripe-style envelope; V1 is the legacy flat shape and is read-only via this API.
        /// </param>
        /// <param name="createdAt">
        /// The date the webhook was created.
        /// </param>
        /// <param name="description">
        /// The webhook's description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksPublicUpdateResponse(
            string id,
            string name,
            string url,
            global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicUpdateResponseEventType> eventTypes,
            global::ModerationAPI.WebhooksPublicUpdateResponsePayloadVersion payloadVersion,
            string createdAt,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.EventTypes = eventTypes ?? throw new global::System.ArgumentNullException(nameof(eventTypes));
            this.PayloadVersion = payloadVersion;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksPublicUpdateResponse" /> class.
        /// </summary>
        public WebhooksPublicUpdateResponse()
        {
        }

    }
}