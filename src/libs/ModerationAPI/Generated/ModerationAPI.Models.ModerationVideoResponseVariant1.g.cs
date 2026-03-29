
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationVideoResponseVariant1
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
        public required global::ModerationAPI.ModerationVideoResponseVariant1Request Request { get; set; }

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
        public global::ModerationAPI.ModerationVideoResponseVariant1Author2? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationVideoResponseVariant1" /> class.
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
        /// <param name="error">
        /// Error message if the request failed
        /// </param>
        /// <param name="contentId">
        /// The ID of the content. Only returned if the content was stored.
        /// </param>
        /// <param name="author">
        /// The author of the content if your account has authors enabled. Requires you to send authorId when submitting content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationVideoResponseVariant1(
            string status,
            global::ModerationAPI.ModerationVideoResponseVariant1Request request,
            bool flagged,
            object? error,
            string? contentId,
            global::ModerationAPI.ModerationVideoResponseVariant1Author2? author)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Error = error;
            this.ContentId = contentId;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Flagged = flagged;
            this.Author = author;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationVideoResponseVariant1" /> class.
        /// </summary>
        public ModerationVideoResponseVariant1()
        {
        }
    }
}