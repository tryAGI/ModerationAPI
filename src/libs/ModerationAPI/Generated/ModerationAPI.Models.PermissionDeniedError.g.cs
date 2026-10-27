
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The API key cannot do this, or the plan limit for this resource is reached.
    /// </summary>
    public sealed partial class PermissionDeniedError
    {
        /// <summary>
        /// Broad error category. Stable; safe to switch on.
        /// </summary>
        /// <default>"permission_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "permission_error";

        /// <summary>
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `permission_denied`: The API key cannot perform this request.<br/>
        /// - `account_disabled`: The organization account is disabled.<br/>
        /// - `quota_exceeded`: The organization has used all API requests on its plan.<br/>
        /// - `plan_feature_unavailable`: The current plan does not include this feature.<br/>
        /// - `plan_limit_exceeded`: The request goes over a limit of the current plan.<br/>
        /// - `organization_key_required`: This endpoint needs an organization API key, but a project key was used.<br/>
        /// - `missing_key_permission`: The organization key does not have the permission this endpoint needs.<br/>
        /// - `project_not_reachable`: The organization key is limited to other projects.<br/>
        /// Example: permission_denied
        /// </summary>
        /// <example>permission_denied</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.PermissionDeniedErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.PermissionDeniedErrorCode Code { get; set; }

        /// <summary>
        /// Human-readable explanation.<br/>
        /// Example: Insufficient access
        /// </summary>
        /// <example>Insufficient access</example>
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
        /// Initializes a new instance of the <see cref="PermissionDeniedError" /> class.
        /// </summary>
        /// <param name="code">
        /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
        /// - `permission_denied`: The API key cannot perform this request.<br/>
        /// - `account_disabled`: The organization account is disabled.<br/>
        /// - `quota_exceeded`: The organization has used all API requests on its plan.<br/>
        /// - `plan_feature_unavailable`: The current plan does not include this feature.<br/>
        /// - `plan_limit_exceeded`: The request goes over a limit of the current plan.<br/>
        /// - `organization_key_required`: This endpoint needs an organization API key, but a project key was used.<br/>
        /// - `missing_key_permission`: The organization key does not have the permission this endpoint needs.<br/>
        /// - `project_not_reachable`: The organization key is limited to other projects.<br/>
        /// Example: permission_denied
        /// </param>
        /// <param name="message">
        /// Human-readable explanation.<br/>
        /// Example: Insufficient access
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
        public PermissionDeniedError(
            global::ModerationAPI.PermissionDeniedErrorCode code,
            string message,
            string requestId,
            string docUrl,
            global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>? issues,
            string type = "permission_error")
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Issues = issues;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.DocUrl = docUrl ?? throw new global::System.ArgumentNullException(nameof(docUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionDeniedError" /> class.
        /// </summary>
        public PermissionDeniedError()
        {
        }

    }
}