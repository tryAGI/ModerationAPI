
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NewModerateModerateResponseCampaignCluster
    {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// baseline: what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. drift: a person confirmed the drift.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponseCampaignClusterStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponseCampaignClusterStatus Status { get; set; }

        /// <summary>
        /// How similar the message is to what the campaign is expected to send, from 0 to 1, or null when there is nothing to compare with yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_similarity")]
        public double? BaselineSimilarity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseCampaignCluster" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the cluster.
        /// </param>
        /// <param name="status">
        /// baseline: what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. drift: a person confirmed the drift.
        /// </param>
        /// <param name="baselineSimilarity">
        /// How similar the message is to what the campaign is expected to send, from 0 to 1, or null when there is nothing to compare with yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponseCampaignCluster(
            string id,
            global::ModerationAPI.NewModerateModerateResponseCampaignClusterStatus status,
            double? baselineSimilarity)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.BaselineSimilarity = baselineSimilarity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponseCampaignCluster" /> class.
        /// </summary>
        public NewModerateModerateResponseCampaignCluster()
        {
        }

    }
}