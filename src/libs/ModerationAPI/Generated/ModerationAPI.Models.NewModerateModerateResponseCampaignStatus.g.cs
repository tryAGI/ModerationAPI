
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The status of the campaign. A paused campaign is rejected.
    /// </summary>
    public enum NewModerateModerateResponseCampaignStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseCampaignStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseCampaignStatus value)
        {
            return value switch
            {
                NewModerateModerateResponseCampaignStatus.Active => "active",
                NewModerateModerateResponseCampaignStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseCampaignStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => NewModerateModerateResponseCampaignStatus.Active,
                "paused" => NewModerateModerateResponseCampaignStatus.Paused,
                _ => null,
            };
        }
    }
}