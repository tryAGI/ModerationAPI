
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksPublicCreateRequest
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
        /// The webhook's URL. We'll call this URL when an event occurs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Event types this webhook subscribes to. One webhook URL receives all events you list here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventTypes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateRequestEventType> EventTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksPublicCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The webhook's name, used to identify it in the dashboard
        /// </param>
        /// <param name="url">
        /// The webhook's URL. We'll call this URL when an event occurs.
        /// </param>
        /// <param name="eventTypes">
        /// Event types this webhook subscribes to. One webhook URL receives all events you list here.
        /// </param>
        /// <param name="description">
        /// The webhook's description
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksPublicCreateRequest(
            string name,
            string url,
            global::System.Collections.Generic.IList<global::ModerationAPI.WebhooksPublicCreateRequestEventType> eventTypes,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.EventTypes = eventTypes ?? throw new global::System.ArgumentNullException(nameof(eventTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksPublicCreateRequest" /> class.
        /// </summary>
        public WebhooksPublicCreateRequest()
        {
        }

    }
}