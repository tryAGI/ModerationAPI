
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateChannelWordlistsResponse
    {
        /// <summary>
        /// Every wordlist in the organization, with whether the channel uses it. Wordlists the channel does not use show the default settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordlists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ChannelWordlist> Wordlists { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelWordlistsResponse" /> class.
        /// </summary>
        /// <param name="wordlists">
        /// Every wordlist in the organization, with whether the channel uses it. Wordlists the channel does not use show the default settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelWordlistsResponse(
            global::System.Collections.Generic.IList<global::ModerationAPI.ChannelWordlist> wordlists)
        {
            this.Wordlists = wordlists ?? throw new global::System.ArgumentNullException(nameof(wordlists));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelWordlistsResponse" /> class.
        /// </summary>
        public UpdateChannelWordlistsResponse()
        {
        }

    }
}