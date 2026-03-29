
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountGetResponse
    {
        /// <summary>
        /// ID of the account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the paid plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paid_plan_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PaidPlanName { get; set; }

        /// <summary>
        /// Text API quota
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_api_quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TextApiQuota { get; set; }

        /// <summary>
        /// Remaining quota
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RemainingQuota { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_project")]
        public global::ModerationAPI.AccountGetResponseCurrentProject? CurrentProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the account
        /// </param>
        /// <param name="paidPlanName">
        /// Name of the paid plan
        /// </param>
        /// <param name="textApiQuota">
        /// Text API quota
        /// </param>
        /// <param name="remainingQuota">
        /// Remaining quota
        /// </param>
        /// <param name="currentProject"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountGetResponse(
            string id,
            string paidPlanName,
            double textApiQuota,
            double remainingQuota,
            global::ModerationAPI.AccountGetResponseCurrentProject? currentProject)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PaidPlanName = paidPlanName ?? throw new global::System.ArgumentNullException(nameof(paidPlanName));
            this.TextApiQuota = textApiQuota;
            this.RemainingQuota = remainingQuota;
            this.CurrentProject = currentProject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGetResponse" /> class.
        /// </summary>
        public AccountGetResponse()
        {
        }
    }
}