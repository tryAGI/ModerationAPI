
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The detection mode.
    /// </summary>
    public enum ModerationTextResponseVariant1UrlMode
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
    public static class ModerationTextResponseVariant1UrlModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1UrlMode value)
        {
            return value switch
            {
                ModerationTextResponseVariant1UrlMode.Normal => "NORMAL",
                ModerationTextResponseVariant1UrlMode.Paranoid => "PARANOID",
                ModerationTextResponseVariant1UrlMode.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1UrlMode? ToEnum(string value)
        {
            return value switch
            {
                "NORMAL" => ModerationTextResponseVariant1UrlMode.Normal,
                "PARANOID" => ModerationTextResponseVariant1UrlMode.Paranoid,
                "SUSPICIOUS" => ModerationTextResponseVariant1UrlMode.Suspicious,
                _ => null,
            };
        }
    }
}