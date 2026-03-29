
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
        public global::ModerationAPI.ModerationTextResponseVariant1Author2? Author { get; set; }

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
        /// The NSFW model output if enabled in your project. Read more at https://docs.moderationapi.com/models/nsfw
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nsfw")]
        public global::ModerationAPI.ModerationTextResponseVariant1Nsfw? Nsfw { get; set; }

        /// <summary>
        /// The toxicity model output if enabled in your project. Read more at https://docs.moderationapi.com/models/toxicity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toxicity")]
        public global::ModerationAPI.ModerationTextResponseVariant1Toxicity? Toxicity { get; set; }

        /// <summary>
        /// The spam model output if enabled in your project. Read more at https://docs.moderationapi.com/models/spam
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public global::ModerationAPI.ModerationTextResponseVariant1Quality? Quality { get; set; }

        /// <summary>
        /// The sentiment model output if enabled in your project. Read more at https://docs.moderationapi.com/models/sentiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        public global::ModerationAPI.ModerationTextResponseVariant1Sentiment? Sentiment { get; set; }

        /// <summary>
        /// The propriety model output if enabled in your project. Read more at https://docs.moderationapi.com/models/propriety
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propriety")]
        public global::ModerationAPI.ModerationTextResponseVariant1Propriety? Propriety { get; set; }

        /// <summary>
        /// The email entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public global::ModerationAPI.ModerationTextResponseVariant1Email? Email { get; set; }

        /// <summary>
        /// The phone entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/phone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public global::ModerationAPI.ModerationTextResponseVariant1Phone? Phone { get; set; }

        /// <summary>
        /// The url entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public global::ModerationAPI.ModerationTextResponseVariant1Url? Url { get; set; }

        /// <summary>
        /// The address entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public global::ModerationAPI.ModerationTextResponseVariant1Address? Address { get; set; }

        /// <summary>
        /// The name entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::ModerationAPI.ModerationTextResponseVariant1Name? Name { get; set; }

        /// <summary>
        /// The username entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/username
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public global::ModerationAPI.ModerationTextResponseVariant1Username? Username { get; set; }

        /// <summary>
        /// The profanity entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/profanity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profanity")]
        public global::ModerationAPI.ModerationTextResponseVariant1Profanity? Profanity { get; set; }

        /// <summary>
        /// The sensitive numbers entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/sensitive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitive")]
        public global::ModerationAPI.ModerationTextResponseVariant1Sensitive? Sensitive { get; set; }

        /// <summary>
        /// The wordlist entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordlist")]
        public global::ModerationAPI.ModerationTextResponseVariant1Wordlist? Wordlist { get; set; }

        /// <summary>
        /// The wordlist entity matcher outputs if enabled in your project. Read more at https://docs.moderationapi.com/models/word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordlists")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.ModerationTextResponseVariant1Wordlist2>? Wordlists { get; set; }

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
        /// <param name="error">
        /// Error message if the request failed
        /// </param>
        /// <param name="contentId">
        /// The ID of the content. Only returned if the content was stored.
        /// </param>
        /// <param name="author">
        /// The author of the content if your account has authors enabled. Requires you to send authorId when submitting content.
        /// </param>
        /// <param name="nsfw">
        /// The NSFW model output if enabled in your project. Read more at https://docs.moderationapi.com/models/nsfw
        /// </param>
        /// <param name="toxicity">
        /// The toxicity model output if enabled in your project. Read more at https://docs.moderationapi.com/models/toxicity
        /// </param>
        /// <param name="quality">
        /// The spam model output if enabled in your project. Read more at https://docs.moderationapi.com/models/spam
        /// </param>
        /// <param name="sentiment">
        /// The sentiment model output if enabled in your project. Read more at https://docs.moderationapi.com/models/sentiment
        /// </param>
        /// <param name="propriety">
        /// The propriety model output if enabled in your project. Read more at https://docs.moderationapi.com/models/propriety
        /// </param>
        /// <param name="email">
        /// The email entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/email
        /// </param>
        /// <param name="phone">
        /// The phone entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/phone
        /// </param>
        /// <param name="url">
        /// The url entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/url
        /// </param>
        /// <param name="address">
        /// The address entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/address
        /// </param>
        /// <param name="name">
        /// The name entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/name
        /// </param>
        /// <param name="username">
        /// The username entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/username
        /// </param>
        /// <param name="profanity">
        /// The profanity entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/profanity
        /// </param>
        /// <param name="sensitive">
        /// The sensitive numbers entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/sensitive
        /// </param>
        /// <param name="wordlist">
        /// The wordlist entity matcher output if enabled in your project. Read more at https://docs.moderationapi.com/models/word
        /// </param>
        /// <param name="wordlists">
        /// The wordlist entity matcher outputs if enabled in your project. Read more at https://docs.moderationapi.com/models/word
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
            object? error,
            string? contentId,
            global::ModerationAPI.ModerationTextResponseVariant1Author2? author,
            global::ModerationAPI.ModerationTextResponseVariant1Nsfw? nsfw,
            global::ModerationAPI.ModerationTextResponseVariant1Toxicity? toxicity,
            global::ModerationAPI.ModerationTextResponseVariant1Quality? quality,
            global::ModerationAPI.ModerationTextResponseVariant1Sentiment? sentiment,
            global::ModerationAPI.ModerationTextResponseVariant1Propriety? propriety,
            global::ModerationAPI.ModerationTextResponseVariant1Email? email,
            global::ModerationAPI.ModerationTextResponseVariant1Phone? phone,
            global::ModerationAPI.ModerationTextResponseVariant1Url? url,
            global::ModerationAPI.ModerationTextResponseVariant1Address? address,
            global::ModerationAPI.ModerationTextResponseVariant1Name? name,
            global::ModerationAPI.ModerationTextResponseVariant1Username? username,
            global::ModerationAPI.ModerationTextResponseVariant1Profanity? profanity,
            global::ModerationAPI.ModerationTextResponseVariant1Sensitive? sensitive,
            global::ModerationAPI.ModerationTextResponseVariant1Wordlist? wordlist,
            global::System.Collections.Generic.IList<global::ModerationAPI.ModerationTextResponseVariant1Wordlist2>? wordlists)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Error = error;
            this.ContentId = contentId;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Flagged = flagged;
            this.Author = author;
            this.ContentModerated = contentModerated;
            this.UnicodeSpoofing = unicodeSpoofing;
            this.DataFound = dataFound;
            this.Original = original ?? throw new global::System.ArgumentNullException(nameof(original));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Nsfw = nsfw;
            this.Toxicity = toxicity;
            this.Quality = quality;
            this.Sentiment = sentiment;
            this.Propriety = propriety;
            this.Email = email;
            this.Phone = phone;
            this.Url = url;
            this.Address = address;
            this.Name = name;
            this.Username = username;
            this.Profanity = profanity;
            this.Sensitive = sensitive;
            this.Wordlist = wordlist;
            this.Wordlists = wordlists;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationTextResponseVariant1" /> class.
        /// </summary>
        public ModerationTextResponseVariant1()
        {
        }
    }
}