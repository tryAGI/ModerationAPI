
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The ID of the legacy policy, for example `illicit_alcohol`. Policies with an `upgradeTo` can be upgraded.
    /// </summary>
    public enum UpgradeChannelPolicyPolicyId
    {
        /// <summary>
        ///
        /// </summary>
        Adult,
        /// <summary>
        ///
        /// </summary>
        Illicit,
        /// <summary>
        ///
        /// </summary>
        IllicitAlcohol,
        /// <summary>
        ///
        /// </summary>
        IllicitDrugs,
        /// <summary>
        ///
        /// </summary>
        IllicitFirearms,
        /// <summary>
        ///
        /// </summary>
        IllicitGambling,
        /// <summary>
        ///
        /// </summary>
        IllicitTobacco,
        /// <summary>
        ///
        /// </summary>
        IntentToShare,
        /// <summary>
        ///
        /// </summary>
        SelfPromotion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpgradeChannelPolicyPolicyIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpgradeChannelPolicyPolicyId value)
        {
            return value switch
            {
                UpgradeChannelPolicyPolicyId.Adult => "adult",
                UpgradeChannelPolicyPolicyId.Illicit => "illicit",
                UpgradeChannelPolicyPolicyId.IllicitAlcohol => "illicit_alcohol",
                UpgradeChannelPolicyPolicyId.IllicitDrugs => "illicit_drugs",
                UpgradeChannelPolicyPolicyId.IllicitFirearms => "illicit_firearms",
                UpgradeChannelPolicyPolicyId.IllicitGambling => "illicit_gambling",
                UpgradeChannelPolicyPolicyId.IllicitTobacco => "illicit_tobacco",
                UpgradeChannelPolicyPolicyId.IntentToShare => "intent_to_share",
                UpgradeChannelPolicyPolicyId.SelfPromotion => "self_promotion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpgradeChannelPolicyPolicyId? ToEnum(string value)
        {
            return value switch
            {
                "adult" => UpgradeChannelPolicyPolicyId.Adult,
                "illicit" => UpgradeChannelPolicyPolicyId.Illicit,
                "illicit_alcohol" => UpgradeChannelPolicyPolicyId.IllicitAlcohol,
                "illicit_drugs" => UpgradeChannelPolicyPolicyId.IllicitDrugs,
                "illicit_firearms" => UpgradeChannelPolicyPolicyId.IllicitFirearms,
                "illicit_gambling" => UpgradeChannelPolicyPolicyId.IllicitGambling,
                "illicit_tobacco" => UpgradeChannelPolicyPolicyId.IllicitTobacco,
                "intent_to_share" => UpgradeChannelPolicyPolicyId.IntentToShare,
                "self_promotion" => UpgradeChannelPolicyPolicyId.SelfPromotion,
                _ => null,
            };
        }
    }
}