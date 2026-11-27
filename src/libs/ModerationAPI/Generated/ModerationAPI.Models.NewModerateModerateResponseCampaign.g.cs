
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NewModerateModerateResponseCampaign
    {
        /// <summary>
        /// Your ID for the campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the campaign. A paused campaign is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponseCampaignStatus Status { get; set; }

        /// <summary>
        /// The status of the brand, or null when the campaign has none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand_status")]
        public global::ModerationAPI.NewModerateModerateResponseCampaignBrandStatus? BrandStatus { get; set; }

        /// <summary>
        /// The campaign signals of the message: off_purpose (the message is in a group that does not fit the purpose of the campaign), sender_missing, sender_similar, sender_mismatch (the sender name), url_not_declared, url_mismatch (the links). They are also the labels of the `campaign` policy in `policies`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseCampaignSignal> Signals { get; set; }

        /// <summary>
        /// The group of similar messages of the campaign that this message is in, or null when it is in none yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cluster")]
        public global::ModerationAPI.NewModerateModerateResponseCampaignCluster? Cluster { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseCampaign" /> class.
        /// </summary>
        /// <param name="id">
        /// Your ID for the campaign.
        /// </param>
        /// <param name="status">
        /// The status of the campaign. A paused campaign is rejected.
        /// </param>
        /// <param name="signals">
        /// The campaign signals of the message: off_purpose (the message is in a group that does not fit the purpose of the campaign), sender_missing, sender_similar, sender_mismatch (the sender name), url_not_declared, url_mismatch (the links). They are also the labels of the `campaign` policy in `policies`.
        /// </param>
        /// <param name="brandStatus">
        /// The status of the brand, or null when the campaign has none.
        /// </param>
        /// <param name="cluster">
        /// The group of similar messages of the campaign that this message is in, or null when it is in none yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseCampaign(
            string id,
            global::ModerationAPI.NewModerateModerateResponseCampaignStatus status,
            global::System.Collections.Generic.IList<global::ModerationAPI.NewModerateModerateResponseCampaignSignal> signals,
            global::ModerationAPI.NewModerateModerateResponseCampaignBrandStatus? brandStatus,
            global::ModerationAPI.NewModerateModerateResponseCampaignCluster? cluster)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.BrandStatus = brandStatus;
            this.Signals = signals ?? throw new global::System.ArgumentNullException(nameof(signals));
            this.Cluster = cluster;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseCampaign" /> class.
        /// </summary>
        public NewModerateModerateResponseCampaign()
        {
        }

    }
}