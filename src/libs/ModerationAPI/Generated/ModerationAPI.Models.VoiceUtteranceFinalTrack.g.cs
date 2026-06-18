
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceUtteranceFinalTrack
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceUtteranceFinalTrackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceUtteranceFinalTrack value)
        {
            return value switch
            {
                VoiceUtteranceFinalTrack.Inbound => "inbound",
                VoiceUtteranceFinalTrack.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceUtteranceFinalTrack? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => VoiceUtteranceFinalTrack.Inbound,
                "outbound" => VoiceUtteranceFinalTrack.Outbound,
                _ => null,
            };
        }
    }
}