
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The detection mode.
    /// </summary>
    public enum ModerationTextResponseVariant1PhoneMode
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
    public static class ModerationTextResponseVariant1PhoneModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1PhoneMode value)
        {
            return value switch
            {
                ModerationTextResponseVariant1PhoneMode.Normal => "NORMAL",
                ModerationTextResponseVariant1PhoneMode.Paranoid => "PARANOID",
                ModerationTextResponseVariant1PhoneMode.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1PhoneMode? ToEnum(string value)
        {
            return value switch
            {
                "NORMAL" => ModerationTextResponseVariant1PhoneMode.Normal,
                "PARANOID" => ModerationTextResponseVariant1PhoneMode.Paranoid,
                "SUSPICIOUS" => ModerationTextResponseVariant1PhoneMode.Suspicious,
                _ => null,
            };
        }
    }
}