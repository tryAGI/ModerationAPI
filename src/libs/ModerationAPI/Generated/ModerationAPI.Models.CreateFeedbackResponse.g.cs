
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFeedbackResponse
    {
        /// <summary>
        /// ID of the feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The team received the feedback.
        /// </summary>
        /// <default>"received"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "received";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the feedback.
        /// </param>
        /// <param name="status">
        /// The team received the feedback.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFeedbackResponse(
            string id,
            string status = "received")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackResponse" /> class.
        /// </summary>
        public CreateFeedbackResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CreateFeedbackResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CreateFeedbackResponse FromId(string id)
        {
            return new CreateFeedbackResponse
            {
                Id = id,
            };
        }

    }
}