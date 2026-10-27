
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The request is valid JSON but cannot be processed.
    /// </summary>
    public sealed partial class UnprocessableEntityError
    {
        /// <summary>
        /// Broad error category. Stable; safe to switch on.
        /// </summary>
        /// <default>"invalid_request_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "invalid_request_error";

        /// <summary>
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `unprocessable_content`: The request is valid but cannot be processed.<br/>
        /// Example: unprocessable_content
        /// </summary>
        /// <example>unprocessable_content</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.UnprocessableEntityErrorCodeJsonConverter))]
        public global::ModerationAPI.UnprocessableEntityErrorCode Code { get; set; }

        /// <summary>
        /// Human-readable explanation.<br/>
        /// Example: Unprocessable content
        /// </summary>
        /// <example>Unprocessable content</example>
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
        /// Initializes a new instance of the <see cref="UnprocessableEntityError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable explanation.<br/>
        /// Example: Unprocessable content
        /// </param>
        /// <param name="requestId">
        /// Identifies this request. Include it when you contact support.<br/>
        /// Example: h8fkz6kkzoa446ffve37atys
        /// </param>
        /// <param name="docUrl">
        /// Documentation for this `code`.
        /// </param>
        /// <param name="code">
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `unprocessable_content`: The request is valid but cannot be processed.<br/>
        /// Example: unprocessable_content
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
        public UnprocessableEntityError(
            string message,
            string requestId,
            string docUrl,
            global::ModerationAPI.UnprocessableEntityErrorCode code,
            global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>? issues,
            string type = "invalid_request_error")
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Issues = issues;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.DocUrl = docUrl ?? throw new global::System.ArgumentNullException(nameof(docUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnprocessableEntityError" /> class.
        /// </summary>
        public UnprocessableEntityError()
        {
        }

    }
}