
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ErrorIssue
    {
        /// <summary>
        /// What is wrong.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Location of the invalid field in the request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<string, double?>>? Path { get; set; }

        /// <summary>
        /// Validation rule that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorIssue" /> class.
        /// </summary>
        /// <param name="message">
        /// What is wrong.
        /// </param>
        /// <param name="path">
        /// Location of the invalid field in the request body.
        /// </param>
        /// <param name="code">
        /// Validation rule that failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorIssue(
            string message,
            global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<string, double?>>? path,
            string? code)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Path = path;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorIssue" /> class.
        /// </summary>
        public ErrorIssue()
        {
        }

    }
}