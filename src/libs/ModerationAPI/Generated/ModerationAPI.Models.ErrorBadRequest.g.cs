
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The error information<br/>
    /// Example: {"code":"BAD_REQUEST","message":"Invalid input data","issues":[]}
    /// </summary>
    public sealed partial class ErrorBadRequest
    {
        /// <summary>
        /// The error message<br/>
        /// Example: Invalid input data
        /// </summary>
        /// <example>Invalid input data</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The error code<br/>
        /// Example: BAD_REQUEST
        /// </summary>
        /// <example>BAD_REQUEST</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// An array of issues that were responsible for the error<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorBadRequestIssue>? Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorBadRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message<br/>
        /// Example: Invalid input data
        /// </param>
        /// <param name="code">
        /// The error code<br/>
        /// Example: BAD_REQUEST
        /// </param>
        /// <param name="issues">
        /// An array of issues that were responsible for the error<br/>
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorBadRequest(
            string message,
            string code,
            global::System.Collections.Generic.IList<global::ModerationAPI.ErrorBadRequestIssue>? issues)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Issues = issues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorBadRequest" /> class.
        /// </summary>
        public ErrorBadRequest()
        {
        }
    }
}