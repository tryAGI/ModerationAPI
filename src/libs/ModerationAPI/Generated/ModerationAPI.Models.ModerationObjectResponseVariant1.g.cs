
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationObjectResponseVariant1
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
        public required global::ModerationAPI.ModerationObjectResponseVariant1Request Request { get; set; }

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
        public global::ModerationAPI.ModerationObjectResponseVariant1Author2? Author { get; set; }

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
        /// The scores of each label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Label> Labels { get; set; }

        /// <summary>
        /// The entities found in the content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Entitie> Entities { get; set; }

        /// <summary>
        /// The wordlist entity matcher outputs if enabled in your project. Read more at https://docs.moderationapi.com/models/word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordlists")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Wordlist>? Wordlists { get; set; }

        /// <summary>
        /// The fields in the object and their flags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Field> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1" /> class.
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
        /// <param name="unicodeSpoofing">
        /// Whether the content is using look-alike characters. Often used by spammers.
        /// </param>
        /// <param name="dataFound">
        /// Whether any entity matchers found data for the content
        /// </param>
        /// <param name="labels">
        /// The scores of each label
        /// </param>
        /// <param name="entities">
        /// The entities found in the content
        /// </param>
        /// <param name="fields">
        /// The fields in the object and their flags
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
        /// <param name="wordlists">
        /// The wordlist entity matcher outputs if enabled in your project. Read more at https://docs.moderationapi.com/models/word
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationObjectResponseVariant1(
            string status,
            global::ModerationAPI.ModerationObjectResponseVariant1Request request,
            bool flagged,
            bool unicodeSpoofing,
            bool dataFound,
            global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Label> labels,
            global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Entitie> entities,
            global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Field> fields,
            object? error,
            string? contentId,
            global::ModerationAPI.ModerationObjectResponseVariant1Author2? author,
            global::System.Collections.Generic.IList<global::ModerationAPI.ModerationObjectResponseVariant1Wordlist>? wordlists)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Error = error;
            this.ContentId = contentId;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Flagged = flagged;
            this.Author = author;
            this.UnicodeSpoofing = unicodeSpoofing;
            this.DataFound = dataFound;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
            this.Wordlists = wordlists;
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1" /> class.
        /// </summary>
        public ModerationObjectResponseVariant1()
        {
        }
    }
}