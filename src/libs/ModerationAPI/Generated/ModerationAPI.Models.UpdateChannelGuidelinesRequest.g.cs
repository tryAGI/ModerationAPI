
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateChannelGuidelinesRequest
    {
        /// <summary>
        /// The guidelines to add, change or delete. Guidelines you leave out stay as they are. All changes are saved together, or none when one fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidelines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelGuidelinesRequestGuideline> Guidelines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelGuidelinesRequest" /> class.
        /// </summary>
        /// <param name="guidelines">
        /// The guidelines to add, change or delete. Guidelines you leave out stay as they are. All changes are saved together, or none when one fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelGuidelinesRequest(
            global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelGuidelinesRequestGuideline> guidelines)
        {
            this.Guidelines = guidelines ?? throw new global::System.ArgumentNullException(nameof(guidelines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelGuidelinesRequest" /> class.
        /// </summary>
        public UpdateChannelGuidelinesRequest()
        {
        }

    }
}