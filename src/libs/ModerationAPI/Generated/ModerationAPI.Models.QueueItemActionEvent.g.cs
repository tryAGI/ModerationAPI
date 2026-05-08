
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"queue_item.action","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"act_99999","key":"shadow_ban","name":"Shadow ban","value":"24h","created_at":"2026-05-08T12:36:00.000Z","queue":{"id":"que_abc123"},"item":{"id":"item_xyz791","flagged":true,"labels":[{"label":"spam/SPAM","score":0.94,"flagged":true,"manual":false}],"language":"en","content":{"type":"text","text":"Buy crypto now!"},"timestamp":"2026-05-08T12:34:56.789Z","metadata":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","conversation_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","author_id":"user-555","channel_key":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","meta_type":"comment"},"author":{"id":"auth_555","external_id":"user-555","profile_picture":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","external_link":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","name":"Jane Doe","email":"jane@example.com","company":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","first_seen":1746792000000,"last_seen":1746792000000,"last_incident":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","status":"enabled","trust_level":{"level":1,"manual":false},"block":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","risk_evaluation":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}}
    /// </summary>
    public sealed partial class QueueItemActionEvent
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
        /// Example: queue_item.action
        /// </summary>
        /// <default>"queue_item.action"</default>
        /// <example>queue_item.action</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "queue_item.action";

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
        public required global::ModerationAPI.QueueItemActionEventData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItemActionEvent" /> class.
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
        /// Example: queue_item.action
        /// </param>
        /// <param name="apiVersion">
        /// Example: v2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueItemActionEvent(
            string id,
            global::System.DateTime created,
            global::ModerationAPI.QueueItemActionEventData data,
            string type = "queue_item.action",
            string apiVersion = "v2")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ApiVersion = apiVersion;
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueItemActionEvent" /> class.
        /// </summary>
        public QueueItemActionEvent()
        {
        }
    }
}