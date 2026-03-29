
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The error information<br/>
    /// Example: {"code":"INTERNAL_SERVER_ERROR","message":"Internal server error","issues":[]}
    /// </summary>
    public sealed partial class ErrorInternalServerError
    {
        /// <summary>
        /// The error message<br/>
        /// Example: Internal server error
        /// </summary>
        /// <example>Internal server error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The error code<br/>
        /// Example: INTERNAL_SERVER_ERROR
        /// </summary>
        /// <example>INTERNAL_SERVER_ERROR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// An array of issues that were responsible for the error<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorInternalServerErrorIssue>? Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorInternalServerError" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message<br/>
        /// Example: Internal server error
        /// </param>
        /// <param name="code">
        /// The error code<br/>
        /// Example: INTERNAL_SERVER_ERROR
        /// </param>
        /// <param name="issues">
        /// An array of issues that were responsible for the error<br/>
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorInternalServerError(
            string message,
            string code,
            global::System.Collections.Generic.IList<global::ModerationAPI.ErrorInternalServerErrorIssue>? issues)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Issues = issues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorInternalServerError" /> class.
        /// </summary>
        public ErrorInternalServerError()
        {
        }
    }
}