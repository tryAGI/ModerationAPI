
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceStartFrameTrackName
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
    public static class VoiceStartFrameTrackNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceStartFrameTrackName value)
        {
            return value switch
            {
                VoiceStartFrameTrackName.Inbound => "inbound",
                VoiceStartFrameTrackName.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceStartFrameTrackName? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => VoiceStartFrameTrackName.Inbound,
                "outbound" => VoiceStartFrameTrackName.Outbound,
                _ => null,
            };
        }
    }
}