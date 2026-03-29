
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The detection mode.
    /// </summary>
    public enum ModerationTextResponseVariant1WordlistMode
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
    public static class ModerationTextResponseVariant1WordlistModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1WordlistMode value)
        {
            return value switch
            {
                ModerationTextResponseVariant1WordlistMode.Normal => "NORMAL",
                ModerationTextResponseVariant1WordlistMode.Paranoid => "PARANOID",
                ModerationTextResponseVariant1WordlistMode.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1WordlistMode? ToEnum(string value)
        {
            return value switch
            {
                "NORMAL" => ModerationTextResponseVariant1WordlistMode.Normal,
                "PARANOID" => ModerationTextResponseVariant1WordlistMode.Paranoid,
                "SUSPICIOUS" => ModerationTextResponseVariant1WordlistMode.Suspicious,
                _ => null,
            };
        }
    }
}