
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum NewModerateModerateResponseCampaignBrandStatus
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseCampaignBrandStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseCampaignBrandStatus value)
        {
            return value switch
            {
                NewModerateModerateResponseCampaignBrandStatus.Blocked => "blocked",
                NewModerateModerateResponseCampaignBrandStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseCampaignBrandStatus? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => NewModerateModerateResponseCampaignBrandStatus.Blocked,
                "enabled" => NewModerateModerateResponseCampaignBrandStatus.Enabled,
                _ => null,
            };
        }
    }
}