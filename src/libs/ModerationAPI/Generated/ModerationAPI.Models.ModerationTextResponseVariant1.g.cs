
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModerationTextResponseVariant1
    {
        /// <summary>
        /// Success if the request was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// The ID of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentId")]
        public string? ContentId { get; set; }

        /// <summary>
        /// Information about the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ModerationTextResponseVariant1Request Request { get; set; }

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
        public global::ModerationAPI.ModerationTextResponseVariant1Author? Author { get; set; }

        /// <summary>
        /// Whether the content was moderated or not. Same as `content` !== `original`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_moderated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ContentModerated { get; set; }

        /// <summary>
        /// Whether the content is using look-alike characters. Often used by spammers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unicode_spoofing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UnicodeSpoofing { get; set; }

        /// <summary>
        /// Whether any entity matchers found data for the content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_found")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DataFound { get; set; }

        /// <summary>
        /// The original content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Original { get; set; }

        /// <summary>
        /// The content after moderation. With all mask replacements applied and look-alike characters replaced with the original characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1" /> class.
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
        /// <param name="contentModerated">
        /// Whether the content was moderated or not. Same as `content` !== `original`
        /// </param>
        /// <param name="unicodeSpoofing">
        /// Whether the content is using look-alike characters. Often used by spammers.
        /// </param>
        /// <param name="dataFound">
        /// Whether any entity matchers found data for the content
        /// </param>
        /// <param name="original">
        /// The original content
        /// </param>
        /// <param name="content">
        /// The content after moderation. With all mask replacements applied and look-alike characters replaced with the original characters.
        /// </param>
        /// <param name="contentId">
        /// The ID of the content.
        /// </param>
        /// <param name="author">
        /// The author of the content if your account has authors enabled. Requires you to send authorId when submitting content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationTextResponseVariant1(
            string status,
            global::ModerationAPI.ModerationTextResponseVariant1Request request,
            bool flagged,
            bool contentModerated,
            bool unicodeSpoofing,
            bool dataFound,
            string original,
            string content,
            string? contentId,
            global::ModerationAPI.ModerationTextResponseVariant1Author? author)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ContentId = contentId;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Flagged = flagged;
            this.Author = author;
            this.ContentModerated = contentModerated;
            this.UnicodeSpoofing = unicodeSpoofing;
            this.DataFound = dataFound;
            this.Original = original ?? throw new global::System.ArgumentNullException(nameof(original));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1" /> class.
        /// </summary>
        public ModerationTextResponseVariant1()
        {
        }

    }
}