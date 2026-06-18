
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceMediaFrameMediaTrack
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
    public static class VoiceMediaFrameMediaTrackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceMediaFrameMediaTrack value)
        {
            return value switch
            {
                VoiceMediaFrameMediaTrack.Inbound => "inbound",
                VoiceMediaFrameMediaTrack.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceMediaFrameMediaTrack? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => VoiceMediaFrameMediaTrack.Inbound,
                "outbound" => VoiceMediaFrameMediaTrack.Outbound,
                _ => null,
            };
        }
    }
}