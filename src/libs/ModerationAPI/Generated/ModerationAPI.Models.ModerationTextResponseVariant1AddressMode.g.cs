
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The detection mode.
    /// </summary>
    public enum ModerationTextResponseVariant1AddressMode
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
    public static class ModerationTextResponseVariant1AddressModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1AddressMode value)
        {
            return value switch
            {
                ModerationTextResponseVariant1AddressMode.Normal => "NORMAL",
                ModerationTextResponseVariant1AddressMode.Paranoid => "PARANOID",
                ModerationTextResponseVariant1AddressMode.Suspicious => "SUSPICIOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1AddressMode? ToEnum(string value)
        {
            return value switch
            {
                "NORMAL" => ModerationTextResponseVariant1AddressMode.Normal,
                "PARANOID" => ModerationTextResponseVariant1AddressMode.Paranoid,
                "SUSPICIOUS" => ModerationTextResponseVariant1AddressMode.Suspicious,
                _ => null,
            };
        }
    }
}