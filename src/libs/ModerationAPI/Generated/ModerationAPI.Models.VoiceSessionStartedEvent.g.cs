
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceSessionStartedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        SessionStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceSessionStartedEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceSessionStartedEvent value)
        {
            return value switch
            {
                VoiceSessionStartedEvent.SessionStarted => "session.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceSessionStartedEvent? ToEnum(string value)
        {
            return value switch
            {
                "session.started" => VoiceSessionStartedEvent.SessionStarted,
                _ => null,
            };
        }
    }
}