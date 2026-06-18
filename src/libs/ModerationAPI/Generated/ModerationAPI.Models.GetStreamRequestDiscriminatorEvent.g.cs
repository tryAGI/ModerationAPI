
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetStreamRequestDiscriminatorEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Media,
        /// <summary>
        /// 
        /// </summary>
        Start,
        /// <summary>
        /// 
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStreamRequestDiscriminatorEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStreamRequestDiscriminatorEvent value)
        {
            return value switch
            {
                GetStreamRequestDiscriminatorEvent.Media => "media",
                GetStreamRequestDiscriminatorEvent.Start => "start",
                GetStreamRequestDiscriminatorEvent.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStreamRequestDiscriminatorEvent? ToEnum(string value)
        {
            return value switch
            {
                "media" => GetStreamRequestDiscriminatorEvent.Media,
                "start" => GetStreamRequestDiscriminatorEvent.Start,
                "stop" => GetStreamRequestDiscriminatorEvent.Stop,
                _ => null,
            };
        }
    }
}