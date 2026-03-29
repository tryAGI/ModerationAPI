
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The error information<br/>
    /// Example: {"code":"NOT_FOUND","message":"Not found","issues":[]}
    /// </summary>
    public sealed partial class ErrorNotFound
    {
        /// <summary>
        /// The error message<br/>
        /// Example: Not found
        /// </summary>
        /// <example>Not found</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The error code<br/>
        /// Example: NOT_FOUND
        /// </summary>
        /// <example>NOT_FOUND</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// An array of issues that were responsible for the error<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.ErrorNotFoundIssue>? Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorNotFound" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message<br/>
        /// Example: Not found
        /// </param>
        /// <param name="code">
        /// The error code<br/>
        /// Example: NOT_FOUND
        /// </param>
        /// <param name="issues">
        /// An array of issues that were responsible for the error<br/>
        /// Example: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorNotFound(
            string message,
            string code,
            global::System.Collections.Generic.IList<global::ModerationAPI.ErrorNotFoundIssue>? issues)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Issues = issues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorNotFound" /> class.
        /// </summary>
        public ErrorNotFound()
        {
        }
    }
}