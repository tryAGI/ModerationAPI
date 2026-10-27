
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFeedbackRequest
    {
        /// <summary>
        /// A short summary of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// What you tried to do, why, and what is missing or does not work. Plain text. Blank lines start new paragraphs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The kind of feedback.<br/>
        /// Default Value: feature_request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.CreateFeedbackRequestTypeJsonConverter))]
        public global::ModerationAPI.CreateFeedbackRequestType? Type { get; set; }

        /// <summary>
        /// Where the feedback was written: MCP server, agent skill, CLI or API.<br/>
        /// Default Value: api
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.CreateFeedbackRequestSourceJsonConverter))]
        public global::ModerationAPI.CreateFeedbackRequestSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// A short summary of the request.
        /// </param>
        /// <param name="description">
        /// What you tried to do, why, and what is missing or does not work. Plain text. Blank lines start new paragraphs.
        /// </param>
        /// <param name="type">
        /// The kind of feedback.<br/>
        /// Default Value: feature_request
        /// </param>
        /// <param name="source">
        /// Where the feedback was written: MCP server, agent skill, CLI or API.<br/>
        /// Default Value: api
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFeedbackRequest(
            string title,
            string description,
            global::ModerationAPI.CreateFeedbackRequestType? type,
            global::ModerationAPI.CreateFeedbackRequestSource? source)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackRequest" /> class.
        /// </summary>
        public CreateFeedbackRequest()
        {
        }

    }
}