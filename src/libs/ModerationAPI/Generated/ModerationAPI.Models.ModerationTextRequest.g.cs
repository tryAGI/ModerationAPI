
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Input parameters for text moderation
    /// </summary>
    public sealed partial class ModerationTextRequest
    {
        /// <summary>
        /// The unique ID of the content in your database.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentId")]
        public string? ContentId { get; set; }

        /// <summary>
        /// The text you'd like to analyze. We recommend to submit plain text or HTML
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// The key of the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelKey")]
        public string? ChannelKey { get; set; }

        /// <summary>
        /// Do not store the content. The content won't enter the review queue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doNotStore")]
        public bool? DoNotStore { get; set; }

        /// <summary>
        /// The author of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorId")]
        public string? AuthorId { get; set; }

        /// <summary>
        /// For example the ID of a chat room or a post
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextId")]
        public string? ContextId { get; set; }

        /// <summary>
        /// Any metadata you want to store with the content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextRequest" /> class.
        /// </summary>
        /// <param name="value">
        /// The text you'd like to analyze. We recommend to submit plain text or HTML
        /// </param>
        /// <param name="contentId">
        /// The unique ID of the content in your database.
        /// </param>
        /// <param name="channelKey">
        /// The key of the channel.
        /// </param>
        /// <param name="doNotStore">
        /// Do not store the content. The content won't enter the review queue
        /// </param>
        /// <param name="authorId">
        /// The author of the content.
        /// </param>
        /// <param name="contextId">
        /// For example the ID of a chat room or a post
        /// </param>
        /// <param name="metadata">
        /// Any metadata you want to store with the content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationTextRequest(
            string value,
            string? contentId,
            string? channelKey,
            bool? doNotStore,
            string? authorId,
            string? contextId,
            object? metadata)
        {
            this.ContentId = contentId;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.ChannelKey = channelKey;
            this.DoNotStore = doNotStore;
            this.AuthorId = authorId;
            this.ContextId = contextId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextRequest" /> class.
        /// </summary>
        public ModerationTextRequest()
        {
        }
    }
}