
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Trade-off between transcription speed and accuracy.
    /// </summary>
    public enum ManagementChannelsUpdateRequestTranscriptionQuality
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
    public static class ManagementChannelsUpdateRequestTranscriptionQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagementChannelsUpdateRequestTranscriptionQuality value)
        {
            return value switch
            {
                ManagementChannelsUpdateRequestTranscriptionQuality.Accuracy => "ACCURACY",
                ManagementChannelsUpdateRequestTranscriptionQuality.Balanced => "BALANCED",
                ManagementChannelsUpdateRequestTranscriptionQuality.Speed => "SPEED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagementChannelsUpdateRequestTranscriptionQuality? ToEnum(string value)
        {
            return value switch
            {
                "ACCURACY" => ManagementChannelsUpdateRequestTranscriptionQuality.Accuracy,
                "BALANCED" => ManagementChannelsUpdateRequestTranscriptionQuality.Balanced,
                "SPEED" => ManagementChannelsUpdateRequestTranscriptionQuality.Speed,
                _ => null,
            };
        }
    }
}