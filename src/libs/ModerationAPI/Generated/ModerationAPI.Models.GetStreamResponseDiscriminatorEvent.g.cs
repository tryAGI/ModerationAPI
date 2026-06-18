
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetStreamResponseDiscriminatorEvent
    {
        /// <summary>
        /// 
        /// </summary>
        SessionEnded,
        /// <summary>
        /// 
        /// </summary>
        SessionStarted,
        /// <summary>
        /// 
        /// </summary>
        UtteranceFinal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetStreamResponseDiscriminatorEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStreamResponseDiscriminatorEvent value)
        {
            return value switch
            {
                GetStreamResponseDiscriminatorEvent.SessionEnded => "session.ended",
                GetStreamResponseDiscriminatorEvent.SessionStarted => "session.started",
                GetStreamResponseDiscriminatorEvent.UtteranceFinal => "utterance.final",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStreamResponseDiscriminatorEvent? ToEnum(string value)
        {
            return value switch
            {
                "session.ended" => GetStreamResponseDiscriminatorEvent.SessionEnded,
                "session.started" => GetStreamResponseDiscriminatorEvent.SessionStarted,
                "utterance.final" => GetStreamResponseDiscriminatorEvent.UtteranceFinal,
                _ => null,
            };
        }
    }
}