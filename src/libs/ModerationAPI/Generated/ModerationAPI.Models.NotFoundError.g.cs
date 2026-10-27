
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The resource does not exist or the key cannot see it.
    /// </summary>
    public sealed partial class NotFoundError
    {
        /// <summary>
        /// Broad error category. Stable; safe to switch on.
        /// </summary>
        /// <default>"not_found_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "not_found_error";

        /// <summary>
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `resource_not_found`: The resource does not exist.<br/>
        /// - `action_not_found`: The action does not exist.<br/>
        /// - `author_not_found`: The author does not exist.<br/>
        /// - `queue_not_found`: The review queue does not exist.<br/>
        /// - `queue_item_not_found`: The queue item does not exist in the project.<br/>
        /// - `wordlist_not_found`: The wordlist does not exist.<br/>
        /// - `webhook_not_found`: The webhook does not exist.<br/>
        /// - `project_not_found`: The project does not exist.<br/>
        /// - `channel_not_found`: The channel does not exist.<br/>
        /// Example: resource_not_found
        /// </summary>
        /// <example>resource_not_found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NotFoundErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NotFoundErrorCode Code { get; set; }

        /// <summary>
        /// Human-readable explanation.<br/>
        /// Example: Not found
        /// </summary>
        /// <example>Not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Validation problems, when the request body is invalid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>? Issues { get; set; }

        /// <summary>
        /// Identifies this request. Include it when you contact support.<br/>
        /// Example: h8fkz6kkzoa446ffve37atys
        /// </summary>
        /// <example>h8fkz6kkzoa446ffve37atys</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Documentation for this `code`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError" /> class.
        /// </summary>
        /// <param name="code">
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `resource_not_found`: The resource does not exist.<br/>
        /// - `action_not_found`: The action does not exist.<br/>
        /// - `author_not_found`: The author does not exist.<br/>
        /// - `queue_not_found`: The review queue does not exist.<br/>
        /// - `queue_item_not_found`: The queue item does not exist in the project.<br/>
        /// - `wordlist_not_found`: The wordlist does not exist.<br/>
        /// - `webhook_not_found`: The webhook does not exist.<br/>
        /// - `project_not_found`: The project does not exist.<br/>
        /// - `channel_not_found`: The channel does not exist.<br/>
        /// Example: resource_not_found
        /// </param>
        /// <param name="message">
        /// Human-readable explanation.<br/>
        /// Example: Not found
        /// </param>
        /// <param name="requestId">
        /// Identifies this request. Include it when you contact support.<br/>
        /// Example: h8fkz6kkzoa446ffve37atys
        /// </param>
        /// <param name="docUrl">
        /// Documentation for this `code`.
        /// </param>
        /// <param name="issues">
        /// Validation problems, when the request body is invalid.
        /// </param>
        /// <param name="type">
        /// Broad error category. Stable; safe to switch on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotFoundError(
            global::ModerationAPI.NotFoundErrorCode code,
            string message,
            string requestId,
            string docUrl,
            global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>? issues,
            string type = "not_found_error")
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Issues = issues;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.DocUrl = docUrl ?? throw new global::System.ArgumentNullException(nameof(docUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundError" /> class.
        /// </summary>
        public NotFoundError()
        {
        }

    }
}