
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModerationImageResponseVariant1
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
        public required global::ModerationAPI.ModerationImageResponseVariant1Request Request { get; set; }

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
        public global::ModerationAPI.ModerationImageResponseVariant1Author? Author { get; set; }

        /// <summary>
        /// Whether any entity matchers found data for the content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_found")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DataFound { get; set; }

        /// <summary>
        /// Legacy image labels, approximated from the equivalent policies. Use POST /moderate for the policy probabilities themselves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ModerationImageResponseVariant1Label> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationImageResponseVariant1" /> class.
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
        /// <param name="dataFound">
        /// Whether any entity matchers found data for the content
        /// </param>
        /// <param name="labels">
        /// Legacy image labels, approximated from the equivalent policies. Use POST /moderate for the policy probabilities themselves.
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
        public ModerationImageResponseVariant1(
            string status,
            global::ModerationAPI.ModerationImageResponseVariant1Request request,
            bool flagged,
            bool dataFound,
            global::System.Collections.Generic.IList<global::ModerationAPI.ModerationImageResponseVariant1Label> labels,
            string? contentId,
            global::ModerationAPI.ModerationImageResponseVariant1Author? author)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.ContentId = contentId;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Flagged = flagged;
            this.Author = author;
            this.DataFound = dataFound;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationImageResponseVariant1" /> class.
        /// </summary>
        public ModerationImageResponseVariant1()
        {
        }

    }
}