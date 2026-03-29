
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The type of the object you want to analyze.
    /// </summary>
    public enum ModerationObjectRequestValueType
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        Product,
        /// <summary>
        /// 
        /// </summary>
        Profile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationObjectRequestValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationObjectRequestValueType value)
        {
            return value switch
            {
                ModerationObjectRequestValueType.Event => "event",
                ModerationObjectRequestValueType.Object => "object",
                ModerationObjectRequestValueType.Product => "product",
                ModerationObjectRequestValueType.Profile => "profile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationObjectRequestValueType? ToEnum(string value)
        {
            return value switch
            {
                "event" => ModerationObjectRequestValueType.Event,
                "object" => ModerationObjectRequestValueType.Object,
                "product" => ModerationObjectRequestValueType.Product,
                "profile" => ModerationObjectRequestValueType.Profile,
                _ => null,
            };
        }
    }
}