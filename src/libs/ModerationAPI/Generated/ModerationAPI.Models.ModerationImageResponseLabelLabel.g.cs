
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The label of the model
    /// </summary>
    public enum ModerationImageResponseLabelLabel
    {
        /// <summary>
        /// 
        /// </summary>
        Alcohol,
        /// <summary>
        /// 
        /// </summary>
        Drugs,
        /// <summary>
        /// 
        /// </summary>
        Gore,
        /// <summary>
        /// 
        /// </summary>
        Hate,
        /// <summary>
        /// 
        /// </summary>
        Nudity,
        /// <summary>
        /// 
        /// </summary>
        Smoking,
        /// <summary>
        /// 
        /// </summary>
        Suggestive,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Toxic,
        /// <summary>
        /// 
        /// </summary>
        Violence,
        /// <summary>
        /// 
        /// </summary>
        Weapon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationImageResponseLabelLabelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationImageResponseLabelLabel value)
        {
            return value switch
            {
                ModerationImageResponseLabelLabel.Alcohol => "alcohol",
                ModerationImageResponseLabelLabel.Drugs => "drugs",
                ModerationImageResponseLabelLabel.Gore => "gore",
                ModerationImageResponseLabelLabel.Hate => "hate",
                ModerationImageResponseLabelLabel.Nudity => "nudity",
                ModerationImageResponseLabelLabel.Smoking => "smoking",
                ModerationImageResponseLabelLabel.Suggestive => "suggestive",
                ModerationImageResponseLabelLabel.Text => "text",
                ModerationImageResponseLabelLabel.Toxic => "toxic",
                ModerationImageResponseLabelLabel.Violence => "violence",
                ModerationImageResponseLabelLabel.Weapon => "weapon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationImageResponseLabelLabel? ToEnum(string value)
        {
            return value switch
            {
                "alcohol" => ModerationImageResponseLabelLabel.Alcohol,
                "drugs" => ModerationImageResponseLabelLabel.Drugs,
                "gore" => ModerationImageResponseLabelLabel.Gore,
                "hate" => ModerationImageResponseLabelLabel.Hate,
                "nudity" => ModerationImageResponseLabelLabel.Nudity,
                "smoking" => ModerationImageResponseLabelLabel.Smoking,
                "suggestive" => ModerationImageResponseLabelLabel.Suggestive,
                "text" => ModerationImageResponseLabelLabel.Text,
                "toxic" => ModerationImageResponseLabelLabel.Toxic,
                "violence" => ModerationImageResponseLabelLabel.Violence,
                "weapon" => ModerationImageResponseLabelLabel.Weapon,
                _ => null,
            };
        }
    }
}