
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetStreamSecWebSocketProtocol
    {
        /// <summary>
        /// 
        /// </summary>
        ModerationapiV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStreamSecWebSocketProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStreamSecWebSocketProtocol value)
        {
            return value switch
            {
                GetStreamSecWebSocketProtocol.ModerationapiV1 => "moderationapi.v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStreamSecWebSocketProtocol? ToEnum(string value)
        {
            return value switch
            {
                "moderationapi.v1" => GetStreamSecWebSocketProtocol.ModerationapiV1,
                _ => null,
            };
        }
    }
}