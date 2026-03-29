
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateResponse
    {
        /// <summary>
        /// Potentially modified content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponseContent Content { get; set; }

        /// <summary>
        /// The author of the content if your account has authors enabled. Requires you to send authorId when submitting content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::ModerationAPI.NewModerateModerateResponseAuthor2? Author { get; set; }

        /// <summary>
        /// The evaluation of the content after running the channel policies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponseEvaluation Evaluation { get; set; }

        /// <summary>
        /// The recommendation for the content based on the evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponseRecommendation Recommendation { get; set; }

        /// <summary>
        /// Results of all policies in the channel. Sorted by highest probability.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>> Policies { get; set; }

        /// <summary>
        /// Results of all insights enabled in the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insights")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>> Insights { get; set; }

        /// <summary>
        /// Metadata about the moderation request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponseMeta Meta { get; set; }

        /// <summary>
        /// Policies that had errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponse" /> class.
        /// </summary>
        /// <param name="content">
        /// Potentially modified content.
        /// </param>
        /// <param name="evaluation">
        /// The evaluation of the content after running the channel policies.
        /// </param>
        /// <param name="recommendation">
        /// The recommendation for the content based on the evaluation.
        /// </param>
        /// <param name="policies">
        /// Results of all policies in the channel. Sorted by highest probability.
        /// </param>
        /// <param name="insights">
        /// Results of all insights enabled in the channel.
        /// </param>
        /// <param name="meta">
        /// Metadata about the moderation request
        /// </param>
        /// <param name="author">
        /// The author of the content if your account has authors enabled. Requires you to send authorId when submitting content.
        /// </param>
        /// <param name="errors">
        /// Policies that had errors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponse(
            global::ModerationAPI.NewModerateModerateResponseContent content,
            global::ModerationAPI.NewModerateModerateResponseEvaluation evaluation,
            global::ModerationAPI.NewModerateModerateResponseRecommendation recommendation,
            global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponsePolicieClassifierOutput, global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutput>> policies,
            global::System.Collections.Generic.IList<global::ModerationAPI.OneOf<global::ModerationAPI.NewModerateModerateResponseInsightSentimentInsight, global::ModerationAPI.NewModerateModerateResponseInsightLanguageInsight>> insights,
            global::ModerationAPI.NewModerateModerateResponseMeta meta,
            global::ModerationAPI.NewModerateModerateResponseAuthor2? author,
            global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseError>? errors)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Author = author;
            this.Evaluation = evaluation ?? throw new global::System.ArgumentNullException(nameof(evaluation));
            this.Recommendation = recommendation ?? throw new global::System.ArgumentNullException(nameof(recommendation));
            this.Policies = policies ?? throw new global::System.ArgumentNullException(nameof(policies));
            this.Insights = insights ?? throw new global::System.ArgumentNullException(nameof(insights));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponse" /> class.
        /// </summary>
        public NewModerateModerateResponse()
        {
        }
    }
}