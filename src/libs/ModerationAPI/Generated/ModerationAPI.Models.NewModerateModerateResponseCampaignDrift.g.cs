
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// How far the message is from what the campaign is registered or expected to send: the strongest level of its campaign signals. The signals are the labels of the `campaign` policy in `policies`.
    /// </summary>
    public enum NewModerateModerateResponseCampaignDrift
    {
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Slight,
        /// <summary>
        /// the strongest level of its campaign signals. The signals are the labels of the `campaign` policy in `policies`.
        /// </summary>
        Strong,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseCampaignDriftExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseCampaignDrift value)
        {
            return value switch
            {
                NewModerateModerateResponseCampaignDrift.None => "none",
                NewModerateModerateResponseCampaignDrift.Slight => "slight",
                NewModerateModerateResponseCampaignDrift.Strong => "strong",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseCampaignDrift? ToEnum(string value)
        {
            return value switch
            {
                "none" => NewModerateModerateResponseCampaignDrift.None,
                "slight" => NewModerateModerateResponseCampaignDrift.Slight,
                "strong" => NewModerateModerateResponseCampaignDrift.Strong,
                _ => null,
            };
        }
    }
}