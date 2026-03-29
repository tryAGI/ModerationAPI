
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The error information<br/>
    /// Example: {"code":"FORBIDDEN","message":"Insufficient access","issues":[]}
    /// </summary>
    public sealed partial class ErrorForbidden
    {
        /// <summary>
        /// The error message<br/>
        /// Example: Insufficient access
        /// </summary>
        /// <example>Insufficient access</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The error code<br/>
        /// Example: FORBIDDEN
        /// </summary>
        /// <example>FORBIDDEN</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// An array of issues that were responsible for the error<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorForbiddenIssue>? Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorForbidden" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message<br/>
        /// Example: Insufficient access
        /// </param>
        /// <param name="code">
        /// The error code<br/>
        /// Example: FORBIDDEN
        /// </param>
        /// <param name="issues">
        /// An array of issues that were responsible for the error<br/>
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorForbidden(
            string message,
            string code,
            global::System.Collections.Generic.IList<global::ModerationAPI.ErrorForbiddenIssue>? issues)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Issues = issues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorForbidden" /> class.
        /// </summary>
        public ErrorForbidden()
        {
        }
    }
}