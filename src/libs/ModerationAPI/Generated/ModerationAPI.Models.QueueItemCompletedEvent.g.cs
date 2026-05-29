
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"queue_item.resolved","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"item":{"id":"item_xyz789","flagged":true,"labels":[{"label":"spam/SPAM","score":0.94,"flagged":true,"manual":false}],"language":"en","content":{"type":"text","text":"Buy crypto now!"},"timestamp":"2026-05-08T12:34:56.789Z","metadata":null,"conversation_id":null,"author_id":"user-555","channel_key":null,"meta_type":"comment"},"author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"blocked","trust_level":{"level":-1,"manual":false},"block":{"until":null,"reason":"Repeated spam violations"},"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}},"queue":{"id":"que_abc123"}}}}
    /// </summary>
    public sealed partial class QueueItemCompletedEvent
    {
        /// <summary>
        /// Stable event ID. Use this to dedupe retries.<br/>
        /// Example: evt_clxxx...
        /// </summary>
        /// <example>evt_clxxx...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The event type.<br/>
        /// Example: queue_item.resolved
        /// </summary>
        /// <default>"queue_item.resolved"</default>
        /// <example>queue_item.resolved</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "queue_item.resolved";

        /// <summary>
        /// Example: v2
        /// </summary>
        /// <default>"v2"</default>
        /// <example>v2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string ApiVersion { get; set; } = "v2";

        /// <summary>
        /// ISO 8601 timestamp of when the event was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.QueueItemCompletedEventData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItemCompletedEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable event ID. Use this to dedupe retries.<br/>
        /// Example: evt_clxxx...
        /// </param>
        /// <param name="created">
        /// ISO 8601 timestamp of when the event was emitted.
        /// </param>
        /// <param name="data"></param>
        /// <param name="type">
        /// The event type.<br/>
        /// Example: queue_item.resolved
        /// </param>
        /// <param name="apiVersion">
        /// Example: v2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueItemCompletedEvent(
            string id,
            global::System.DateTime created,
            global::ModerationAPI.QueueItemCompletedEventData data,
            string type = "queue_item.resolved",
            string apiVersion = "v2")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ApiVersion = apiVersion;
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItemCompletedEvent" /> class.
        /// </summary>
        public QueueItemCompletedEvent()
        {
        }

    }
}