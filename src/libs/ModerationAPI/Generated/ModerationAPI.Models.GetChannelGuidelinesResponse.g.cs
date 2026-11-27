
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetChannelGuidelinesResponse
    {
        /// <summary>
        /// The channel's guidelines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidelines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ChannelGuideline> Guidelines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelGuidelinesResponse" /> class.
        /// </summary>
        /// <param name="guidelines">
        /// The channel's guidelines.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChannelGuidelinesResponse(
            global::System.Collections.Generic.IList<global::ModerationAPI.ChannelGuideline> guidelines)
        {
            this.Guidelines = guidelines ?? throw new global::System.ArgumentNullException(nameof(guidelines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelGuidelinesResponse" /> class.
        /// </summary>
        public GetChannelGuidelinesResponse()
        {
        }

    }
}