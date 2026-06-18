
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceStartFrameEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Start,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceStartFrameEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceStartFrameEvent value)
        {
            return value switch
            {
                VoiceStartFrameEvent.Start => "start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceStartFrameEvent? ToEnum(string value)
        {
            return value switch
            {
                "start" => VoiceStartFrameEvent.Start,
                _ => null,
            };
        }
    }
}