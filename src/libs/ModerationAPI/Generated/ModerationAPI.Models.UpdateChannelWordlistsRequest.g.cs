
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateChannelWordlistsRequest
    {
        /// <summary>
        /// The wordlists to change. Wordlists you leave out keep their state. All changes are saved together, or none when one fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordlists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelWordlistsRequestWordlist> Wordlists { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelWordlistsRequest" /> class.
        /// </summary>
        /// <param name="wordlists">
        /// The wordlists to change. Wordlists you leave out keep their state. All changes are saved together, or none when one fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelWordlistsRequest(
            global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelWordlistsRequestWordlist> wordlists)
        {
            this.Wordlists = wordlists ?? throw new global::System.ArgumentNullException(nameof(wordlists));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelWordlistsRequest" /> class.
        /// </summary>
        public UpdateChannelWordlistsRequest()
        {
        }

    }
}