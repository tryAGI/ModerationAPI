
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceUtteranceFinalEvent
    {
        /// <summary>
        /// 
        /// </summary>
        UtteranceFinal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceUtteranceFinalEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceUtteranceFinalEvent value)
        {
            return value switch
            {
                VoiceUtteranceFinalEvent.UtteranceFinal => "utterance.final",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceUtteranceFinalEvent? ToEnum(string value)
        {
            return value switch
            {
                "utterance.final" => VoiceUtteranceFinalEvent.UtteranceFinal,
                _ => null,
            };
        }
    }
}