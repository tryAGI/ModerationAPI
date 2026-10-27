
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsChannelsResponseChannel
    {
        /// <summary>
        /// The channel ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The channel name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Requests received in this channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// Requests flagged in this channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Flagged { get; set; }

        /// <summary>
        /// The share of requests in this channel that were flagged: flagged / requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FlagRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsChannelsResponseChannel" /> class.
        /// </summary>
        /// <param name="id">
        /// The channel ID.
        /// </param>
        /// <param name="name">
        /// The channel name.
        /// </param>
        /// <param name="requests">
        /// Requests received in this channel.
        /// </param>
        /// <param name="flagged">
        /// Requests flagged in this channel.
        /// </param>
        /// <param name="flagRate">
        /// The share of requests in this channel that were flagged: flagged / requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsChannelsResponseChannel(
            string id,
            string name,
            int requests,
            int flagged,
            double flagRate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Requests = requests;
            this.Flagged = flagged;
            this.FlagRate = flagRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsChannelsResponseChannel" /> class.
        /// </summary>
        public GetAnalyticsChannelsResponseChannel()
        {
        }

    }
}