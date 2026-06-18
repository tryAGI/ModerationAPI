
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceMediaFrameEvent
    {
        /// <summary>
        /// 
        /// </summary>
        Media,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceMediaFrameEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceMediaFrameEvent value)
        {
            return value switch
            {
                VoiceMediaFrameEvent.Media => "media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceMediaFrameEvent? ToEnum(string value)
        {
            return value switch
            {
                "media" => VoiceMediaFrameEvent.Media,
                _ => null,
            };
        }
    }
}