
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The messaging campaign (10DLC) that sends this message. Requires the campaign add-on.
    /// </summary>
    public sealed partial class NewModerateModerateRequestCampaign
    {
        /// <summary>
        /// Your ID for the campaign, for example the TCR campaign ID. The campaign is created the first time we see it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Your ID for the brand that owns the campaign, for example the TCR brand ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brandId")]
        public string? BrandId { get; set; }

        /// <summary>
        /// The ID of the account in your system that sends for this campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        public string? AccountId { get; set; }

        /// <summary>
        /// The ID of the sub-account in your system that sends for this campaign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subAccountId")]
        public string? SubAccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestCampaign" /> class.
        /// </summary>
        /// <param name="id">
        /// Your ID for the campaign, for example the TCR campaign ID. The campaign is created the first time we see it.
        /// </param>
        /// <param name="brandId">
        /// Your ID for the brand that owns the campaign, for example the TCR brand ID.
        /// </param>
        /// <param name="accountId">
        /// The ID of the account in your system that sends for this campaign.
        /// </param>
        /// <param name="subAccountId">
        /// The ID of the sub-account in your system that sends for this campaign.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestCampaign(
            string id,
            string? brandId,
            string? accountId,
            string? subAccountId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BrandId = brandId;
            this.AccountId = accountId;
            this.SubAccountId = subAccountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestCampaign" /> class.
        /// </summary>
        public NewModerateModerateRequestCampaign()
        {
        }

    }
}