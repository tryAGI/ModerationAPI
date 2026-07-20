
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"author.blocked","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"act_block_123","key":"block","name":"Block author","value":null,"created_at":"2026-05-08T12:38:00.000Z","author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"blocked","trust_level":{"level":-1,"manual":false},"block":{"until":null,"reason":"Repeated spam violations"},"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}}
    /// </summary>
    public sealed partial class AuthorBlockedEvent
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
        /// Example: author.blocked
        /// </summary>
        /// <default>"author.blocked"</default>
        /// <example>author.blocked</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "author.blocked";

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
        public required global::ModerationAPI.AuthorBlockedEventData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorBlockedEvent" /> class.
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
        /// Example: author.blocked
        /// </param>
        /// <param name="apiVersion">
        /// Example: v2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorBlockedEvent(
            string id,
            global::System.DateTime created,
            global::ModerationAPI.AuthorBlockedEventData data,
            string type = "author.blocked",
            string apiVersion = "v2")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ApiVersion = apiVersion;
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorBlockedEvent" /> class.
        /// </summary>
        public AuthorBlockedEvent()
        {
        }

    }
}