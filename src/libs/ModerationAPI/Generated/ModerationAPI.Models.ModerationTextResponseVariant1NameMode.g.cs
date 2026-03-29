
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The detection mode.
    /// </summary>
    public enum ModerationTextResponseVariant1NameMode
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
    public static class ModerationTextResponseVariant1NameModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1NameMode value)
        {
            return value switch
            {
                ModerationTextResponseVariant1NameMode.Normal => "NORMAL",
                ModerationTextResponseVariant1NameMode.Paranoid => "PARANOID",
                ModerationTextResponseVariant1NameMode.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1NameMode? ToEnum(string value)
        {
            return value switch
            {
                "NORMAL" => ModerationTextResponseVariant1NameMode.Normal,
                "PARANOID" => ModerationTextResponseVariant1NameMode.Paranoid,
                "SUSPICIOUS" => ModerationTextResponseVariant1NameMode.Suspicious,
                _ => null,
            };
        }
    }
}