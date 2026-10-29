
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteWordlistResponse
    {
        /// <summary>
        /// ID of the deleted wordlist
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the wordlist was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// IDs of the channels that used the wordlist. It was removed from them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detachedChannelIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DetachedChannelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWordlistResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted wordlist
        /// </param>
        /// <param name="deleted">
        /// Whether the wordlist was deleted
        /// </param>
        /// <param name="detachedChannelIds">
        /// IDs of the channels that used the wordlist. It was removed from them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteWordlistResponse(
            string id,
            bool deleted,
            global::System.Collections.Generic.IList<string> detachedChannelIds)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.DetachedChannelIds = detachedChannelIds ?? throw new global::System.ArgumentNullException(nameof(detachedChannelIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWordlistResponse" /> class.
        /// </summary>
        public DeleteWordlistResponse()
        {
        }

    }
}