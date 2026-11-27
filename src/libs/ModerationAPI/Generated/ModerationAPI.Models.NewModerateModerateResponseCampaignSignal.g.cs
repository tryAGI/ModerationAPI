
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum NewModerateModerateResponseCampaignSignal
    {
        /// <summary>
        ///
        /// </summary>
        OffPurpose,
        /// <summary>
        ///
        /// </summary>
        SenderMismatch,
        /// <summary>
        ///
        /// </summary>
        SenderMissing,
        /// <summary>
        ///
        /// </summary>
        SenderSimilar,
        /// <summary>
        ///
        /// </summary>
        UrlMismatch,
        /// <summary>
        ///
        /// </summary>
        UrlNotDeclared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseCampaignSignalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseCampaignSignal value)
        {
            return value switch
            {
                NewModerateModerateResponseCampaignSignal.OffPurpose => "off_purpose",
                NewModerateModerateResponseCampaignSignal.SenderMismatch => "sender_mismatch",
                NewModerateModerateResponseCampaignSignal.SenderMissing => "sender_missing",
                NewModerateModerateResponseCampaignSignal.SenderSimilar => "sender_similar",
                NewModerateModerateResponseCampaignSignal.UrlMismatch => "url_mismatch",
                NewModerateModerateResponseCampaignSignal.UrlNotDeclared => "url_not_declared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseCampaignSignal? ToEnum(string value)
        {
            return value switch
            {
                "off_purpose" => NewModerateModerateResponseCampaignSignal.OffPurpose,
                "sender_mismatch" => NewModerateModerateResponseCampaignSignal.SenderMismatch,
                "sender_missing" => NewModerateModerateResponseCampaignSignal.SenderMissing,
                "sender_similar" => NewModerateModerateResponseCampaignSignal.SenderSimilar,
                "url_mismatch" => NewModerateModerateResponseCampaignSignal.UrlMismatch,
                "url_not_declared" => NewModerateModerateResponseCampaignSignal.UrlNotDeclared,
                _ => null,
            };
        }
    }
}