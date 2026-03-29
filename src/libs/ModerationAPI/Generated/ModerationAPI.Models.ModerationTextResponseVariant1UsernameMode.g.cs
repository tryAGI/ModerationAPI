
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The detection mode.
    /// </summary>
    public enum ModerationTextResponseVariant1UsernameMode
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
    public static class ModerationTextResponseVariant1UsernameModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1UsernameMode value)
        {
            return value switch
            {
                ModerationTextResponseVariant1UsernameMode.Normal => "NORMAL",
                ModerationTextResponseVariant1UsernameMode.Paranoid => "PARANOID",
                ModerationTextResponseVariant1UsernameMode.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1UsernameMode? ToEnum(string value)
        {
            return value switch
            {
                "NORMAL" => ModerationTextResponseVariant1UsernameMode.Normal,
                "PARANOID" => ModerationTextResponseVariant1UsernameMode.Paranoid,
                "SUSPICIOUS" => ModerationTextResponseVariant1UsernameMode.Suspicious,
                _ => null,
            };
        }
    }
}