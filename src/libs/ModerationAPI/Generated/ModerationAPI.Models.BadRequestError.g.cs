
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The request is malformed or a parameter is invalid.
    /// </summary>
    public sealed partial class BadRequestError
    {
        /// <summary>
        /// Broad error category. Stable; safe to switch on.
        /// </summary>
        /// <default>"invalid_request_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "invalid_request_error";

        /// <summary>
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `invalid_request`: A parameter is invalid. `message` says which one.<br/>
        /// - `project_id_required`: An organization key called a project endpoint without naming the project in `Project-Id`, and the key reaches more than one project. `message` lists the projects it reaches.<br/>
        /// - `project_name_ambiguous`: The name in `Project-Id` fits more than one project the key reaches. `message` lists them; name the project by ID instead.<br/>
        /// - `validation_failed`: The request body does not match the schema. `issues` lists each problem with its `path`.<br/>
        /// Example: invalid_request
        /// </summary>
        /// <example>invalid_request</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.BadRequestErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.BadRequestErrorCode Code { get; set; }

        /// <summary>
        /// Human-readable explanation.<br/>
        /// Example: Invalid input data
        /// </summary>
        /// <example>Invalid input data</example>
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
        /// Initializes a new instance of the <see cref="BadRequestError" /> class.
        /// </summary>
        /// <param name="code">
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `invalid_request`: A parameter is invalid. `message` says which one.<br/>
        /// - `project_id_required`: An organization key called a project endpoint without naming the project in `Project-Id`, and the key reaches more than one project. `message` lists the projects it reaches.<br/>
        /// - `project_name_ambiguous`: The name in `Project-Id` fits more than one project the key reaches. `message` lists them; name the project by ID instead.<br/>
        /// - `validation_failed`: The request body does not match the schema. `issues` lists each problem with its `path`.<br/>
        /// Example: invalid_request
        /// </param>
        /// <param name="message">
        /// Human-readable explanation.<br/>
        /// Example: Invalid input data
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
        public BadRequestError(
            global::ModerationAPI.BadRequestErrorCode code,
            string message,
            string requestId,
            string docUrl,
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
        /// Initializes a new instance of the <see cref="BadRequestError" /> class.
        /// </summary>
        public BadRequestError()
        {
        }

    }
}