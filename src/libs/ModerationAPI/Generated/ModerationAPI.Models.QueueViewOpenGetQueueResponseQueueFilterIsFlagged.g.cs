
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueViewOpenGetQueueResponseQueueFilterIsFlagged
    {
        /// <summary>
        ///
        /// </summary>
        All,
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
        ShadowFlagged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetQueueResponseQueueFilterIsFlaggedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetQueueResponseQueueFilterIsFlagged value)
        {
            return value switch
            {
                QueueViewOpenGetQueueResponseQueueFilterIsFlagged.All => "ALL",
                QueueViewOpenGetQueueResponseQueueFilterIsFlagged.Flagged => "FLAGGED",
                QueueViewOpenGetQueueResponseQueueFilterIsFlagged.NotFlagged => "NOT_FLAGGED",
                QueueViewOpenGetQueueResponseQueueFilterIsFlagged.ShadowFlagged => "SHADOW_FLAGGED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetQueueResponseQueueFilterIsFlagged? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => QueueViewOpenGetQueueResponseQueueFilterIsFlagged.All,
                "FLAGGED" => QueueViewOpenGetQueueResponseQueueFilterIsFlagged.Flagged,
                "NOT_FLAGGED" => QueueViewOpenGetQueueResponseQueueFilterIsFlagged.NotFlagged,
                "SHADOW_FLAGGED" => QueueViewOpenGetQueueResponseQueueFilterIsFlagged.ShadowFlagged,
                _ => null,
            };
        }
    }
}