
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The API key is missing, invalid or revoked.
    /// </summary>
    public sealed partial class AuthenticationError
    {
        /// <summary>
        /// Broad error category. Stable; safe to switch on.
        /// </summary>
        /// <default>"authentication_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "authentication_error";

        /// <summary>
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `unauthorized`: Authentication failed.<br/>
        /// - `missing_api_key`: No API key in the `Authorization` header.<br/>
        /// - `malformed_api_key`: The `Authorization` header does not contain a valid key format.<br/>
        /// - `invalid_api_key`: The API key does not exist or was revoked.<br/>
        /// Example: unauthorized
        /// </summary>
        /// <example>unauthorized</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.AuthenticationErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.AuthenticationErrorCode Code { get; set; }

        /// <summary>
        /// Human-readable explanation.<br/>
        /// Example: Authorization not provided
        /// </summary>
        /// <example>Authorization not provided</example>
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
        /// Initializes a new instance of the <see cref="AuthenticationError" /> class.
        /// </summary>
        /// <param name="code">
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `unauthorized`: Authentication failed.<br/>
        /// - `missing_api_key`: No API key in the `Authorization` header.<br/>
        /// - `malformed_api_key`: The `Authorization` header does not contain a valid key format.<br/>
        /// - `invalid_api_key`: The API key does not exist or was revoked.<br/>
        /// Example: unauthorized
        /// </param>
        /// <param name="message">
        /// Human-readable explanation.<br/>
        /// Example: Authorization not provided
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
        public AuthenticationError(
            global::ModerationAPI.AuthenticationErrorCode code,
            string message,
            string requestId,
            string docUrl,
            global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>? issues,
            string type = "authentication_error")
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Issues = issues;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.DocUrl = docUrl ?? throw new global::System.ArgumentNullException(nameof(docUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationError" /> class.
        /// </summary>
        public AuthenticationError()
        {
        }

    }
}