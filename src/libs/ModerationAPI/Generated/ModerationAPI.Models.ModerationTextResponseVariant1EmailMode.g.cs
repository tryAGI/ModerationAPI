
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The detection mode.
    /// </summary>
    public enum ModerationTextResponseVariant1EmailMode
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
    public static class ModerationTextResponseVariant1EmailModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1EmailMode value)
        {
            return value switch
            {
                ModerationTextResponseVariant1EmailMode.Normal => "NORMAL",
                ModerationTextResponseVariant1EmailMode.Paranoid => "PARANOID",
                ModerationTextResponseVariant1EmailMode.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1EmailMode? ToEnum(string value)
        {
            return value switch
            {
                "NORMAL" => ModerationTextResponseVariant1EmailMode.Normal,
                "PARANOID" => ModerationTextResponseVariant1EmailMode.Paranoid,
                "SUSPICIOUS" => ModerationTextResponseVariant1EmailMode.Suspicious,
                _ => null,
            };
        }
    }
}