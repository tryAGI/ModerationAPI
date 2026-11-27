
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `classifier` scores content and can flag it. `insight` only reports (sentiment, language, tone). `entity` finds and masks entities (PII, URLs). `custom_model` and `ai_agent` are models made for the organization.
    /// </summary>
    public enum ChannelPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        AiAgent,
        /// <summary>
        ///
        /// </summary>
        Classifier,
        /// <summary>
        ///
        /// </summary>
        CustomModel,
        /// <summary>
        ///
        /// </summary>
        Entity,
        /// <summary>
        ///
        /// </summary>
        Insight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelPolicyType value)
        {
            return value switch
            {
                ChannelPolicyType.AiAgent => "ai_agent",
                ChannelPolicyType.Classifier => "classifier",
                ChannelPolicyType.CustomModel => "custom_model",
                ChannelPolicyType.Entity => "entity",
                ChannelPolicyType.Insight => "insight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "ai_agent" => ChannelPolicyType.AiAgent,
                "classifier" => ChannelPolicyType.Classifier,
                "custom_model" => ChannelPolicyType.CustomModel,
                "entity" => ChannelPolicyType.Entity,
                "insight" => ChannelPolicyType.Insight,
                _ => null,
            };
        }
    }
}