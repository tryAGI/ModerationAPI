
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationImageResponse
    {
        /// <summary>
        /// Success if the request was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Error message if the request failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// The ID of the content. Only returned if the content was stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentId")]
        public string? ContentId { get; set; }

        /// <summary>
        /// Information about the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ModerationImageResponseRequest Request { get; set; }

        /// <summary>
        /// Whether the content was flagged by any models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// The author of the content if your account has authors enabled. Requires you to send authorId when submitting content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::ModerationAPI.ModerationImageResponseAuthor2? Author { get; set; }

        /// <summary>
        /// The scores of each label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ModerationImageResponseLabel> Labels { get; set; }

        /// <summary>
        /// The texts found in the image, if the image text model is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        public global::System.Collections.Generic.IList<string>? Texts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationImageResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Success if the request was successful
        /// </param>
        /// <param name="request">
        /// Information about the request
        /// </param>
        /// <param name="flagged">
        /// Whether the content was flagged by any models
        /// </param>
        /// <param name="labels">
        /// The scores of each label
        /// </param>
        /// <param name="error">
        /// Error message if the request failed
        /// </param>
        /// <param name="contentId">
        /// The ID of the content. Only returned if the content was stored.
        /// </param>
        /// <param name="author">
        /// The author of the content if your account has authors enabled. Requires you to send authorId when submitting content.
        /// </param>
        /// <param name="texts">
        /// The texts found in the image, if the image text model is enabled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationImageResponse(
            string status,
            global::ModerationAPI.ModerationImageResponseRequest request,
            bool flagged,
            global::System.Collections.Generic.IList<global::ModerationAPI.ModerationImageResponseLabel> labels,
            object? error,
            string? contentId,
            global::ModerationAPI.ModerationImageResponseAuthor2? author,
            global::System.Collections.Generic.IList<string>? texts)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Error = error;
            this.ContentId = contentId;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Flagged = flagged;
            this.Author = author;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Texts = texts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationImageResponse" /> class.
        /// </summary>
        public ModerationImageResponse()
        {
        }
    }
}