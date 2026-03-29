
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The detection mode.
    /// </summary>
    public enum ModerationTextResponseVariant1SensitiveMode
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
    public static class ModerationTextResponseVariant1SensitiveModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1SensitiveMode value)
        {
            return value switch
            {
                ModerationTextResponseVariant1SensitiveMode.Normal => "NORMAL",
                ModerationTextResponseVariant1SensitiveMode.Paranoid => "PARANOID",
                ModerationTextResponseVariant1SensitiveMode.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1SensitiveMode? ToEnum(string value)
        {
            return value switch
            {
                "NORMAL" => ModerationTextResponseVariant1SensitiveMode.Normal,
                "PARANOID" => ModerationTextResponseVariant1SensitiveMode.Paranoid,
                "SUSPICIOUS" => ModerationTextResponseVariant1SensitiveMode.Suspicious,
                _ => null,
            };
        }
    }
}