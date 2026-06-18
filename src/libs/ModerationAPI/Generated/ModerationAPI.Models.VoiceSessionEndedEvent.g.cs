
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceSessionEndedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        SessionEnded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSessionEndedEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSessionEndedEvent value)
        {
            return value switch
            {
                VoiceSessionEndedEvent.SessionEnded => "session.ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSessionEndedEvent? ToEnum(string value)
        {
            return value switch
            {
                "session.ended" => VoiceSessionEndedEvent.SessionEnded,
                _ => null,
            };
        }
    }
}