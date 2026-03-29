
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The detection mode.
    /// </summary>
    public enum ModerationTextResponseVariant1ProfanityMode
    {
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Paranoid,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationTextResponseVariant1ProfanityModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1ProfanityMode value)
        {
            return value switch
            {
                ModerationTextResponseVariant1ProfanityMode.Normal => "NORMAL",
                ModerationTextResponseVariant1ProfanityMode.Paranoid => "PARANOID",
                ModerationTextResponseVariant1ProfanityMode.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1ProfanityMode? ToEnum(string value)
        {
            return value switch
            {
                "NORMAL" => ModerationTextResponseVariant1ProfanityMode.Normal,
                "PARANOID" => ModerationTextResponseVariant1ProfanityMode.Paranoid,
                "SUSPICIOUS" => ModerationTextResponseVariant1ProfanityMode.Suspicious,
                _ => null,
            };
        }
    }
}