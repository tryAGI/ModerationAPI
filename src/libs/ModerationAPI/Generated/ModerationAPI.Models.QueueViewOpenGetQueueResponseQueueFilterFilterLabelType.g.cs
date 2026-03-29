
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueueViewOpenGetQueueResponseQueueFilterFilterLabelType
    {
        /// <summary>
        /// 
        /// </summary>
        Flagged,
        /// <summary>
        /// 
        /// </summary>
        NotFlagged,
        /// <summary>
        /// 
        /// </summary>
        Thresholds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetQueueResponseQueueFilterFilterLabelType value)
        {
            return value switch
            {
                QueueViewOpenGetQueueResponseQueueFilterFilterLabelType.Flagged => "FLAGGED",
                QueueViewOpenGetQueueResponseQueueFilterFilterLabelType.NotFlagged => "NOT_FLAGGED",
                QueueViewOpenGetQueueResponseQueueFilterFilterLabelType.Thresholds => "THRESHOLDS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetQueueResponseQueueFilterFilterLabelType? ToEnum(string value)
        {
            return value switch
            {
                "FLAGGED" => QueueViewOpenGetQueueResponseQueueFilterFilterLabelType.Flagged,
                "NOT_FLAGGED" => QueueViewOpenGetQueueResponseQueueFilterFilterLabelType.NotFlagged,
                "THRESHOLDS" => QueueViewOpenGetQueueResponseQueueFilterFilterLabelType.Thresholds,
                _ => null,
            };
        }
    }
}