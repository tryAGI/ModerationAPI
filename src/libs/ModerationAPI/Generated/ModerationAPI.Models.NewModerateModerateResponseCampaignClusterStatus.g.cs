
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// baseline: what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. drift: a person confirmed the drift.
    /// </summary>
    public enum NewModerateModerateResponseCampaignClusterStatus
    {
        /// <summary>
        /// what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. drift: a person confirmed the drift.
        /// </summary>
        Allowed,
        /// <summary>
        /// what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. drift: a person confirmed the drift.
        /// </summary>
        Baseline,
        /// <summary>
        /// what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. drift: a person confirmed the drift.
        /// </summary>
        Drift,
        /// <summary>
        /// what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. drift: a person confirmed the drift.
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseCampaignClusterStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseCampaignClusterStatus value)
        {
            return value switch
            {
                NewModerateModerateResponseCampaignClusterStatus.Allowed => "allowed",
                NewModerateModerateResponseCampaignClusterStatus.Baseline => "baseline",
                NewModerateModerateResponseCampaignClusterStatus.Drift => "drift",
                NewModerateModerateResponseCampaignClusterStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseCampaignClusterStatus? ToEnum(string value)
        {
            return value switch
            {
                "allowed" => NewModerateModerateResponseCampaignClusterStatus.Allowed,
                "baseline" => NewModerateModerateResponseCampaignClusterStatus.Baseline,
                "drift" => NewModerateModerateResponseCampaignClusterStatus.Drift,
                "pending" => NewModerateModerateResponseCampaignClusterStatus.Pending,
                _ => null,
            };
        }
    }
}