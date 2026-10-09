
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Trade-off between transcription speed and accuracy.
    /// </summary>
    public enum ChannelTranscriptionQuality
    {
        /// <summary>
        ///
        /// </summary>
        Accuracy,
        /// <summary>
        ///
        /// </summary>
        Balanced,
        /// <summary>
        ///
        /// </summary>
        Speed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelTranscriptionQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelTranscriptionQuality value)
        {
            return value switch
            {
                ChannelTranscriptionQuality.Accuracy => "ACCURACY",
                ChannelTranscriptionQuality.Balanced => "BALANCED",
                ChannelTranscriptionQuality.Speed => "SPEED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelTranscriptionQuality? ToEnum(string value)
        {
            return value switch
            {
                "ACCURACY" => ChannelTranscriptionQuality.Accuracy,
                "BALANCED" => ChannelTranscriptionQuality.Balanced,
                "SPEED" => ChannelTranscriptionQuality.Speed,
                _ => null,
            };
        }
    }
}