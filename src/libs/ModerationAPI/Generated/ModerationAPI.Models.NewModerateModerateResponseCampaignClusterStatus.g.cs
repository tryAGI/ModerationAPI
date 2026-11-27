
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// baseline: what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. rejected: a person rejected it, and its messages are rejected.
    /// </summary>
    public enum NewModerateModerateResponseCampaignClusterStatus
    {
        /// <summary>
        /// what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. rejected: a person rejected it, and its messages are rejected.
        /// </summary>
        Allowed,
        /// <summary>
        /// what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. rejected: a person rejected it, and its messages are rejected.
        /// </summary>
        Baseline,
        /// <summary>
        /// what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. rejected: a person rejected it, and its messages are rejected.
        /// </summary>
        Pending,
        /// <summary>
        /// what the campaign is expected to send. pending: a new group that no person decided yet. allowed: a person allowed it. rejected: a person rejected it, and its messages are rejected.
        /// </summary>
        Rejected,
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
                NewModerateModerateResponseCampaignClusterStatus.Pending => "pending",
                NewModerateModerateResponseCampaignClusterStatus.Rejected => "rejected",
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
                "pending" => NewModerateModerateResponseCampaignClusterStatus.Pending,
                "rejected" => NewModerateModerateResponseCampaignClusterStatus.Rejected,
                _ => null,
            };
        }
    }
}