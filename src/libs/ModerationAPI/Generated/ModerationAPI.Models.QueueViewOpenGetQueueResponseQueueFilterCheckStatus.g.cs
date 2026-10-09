
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueViewOpenGetQueueResponseQueueFilterCheckStatus
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Checked,
        /// <summary>
        ///
        /// </summary>
        Unchecked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetQueueResponseQueueFilterCheckStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetQueueResponseQueueFilterCheckStatus value)
        {
            return value switch
            {
                QueueViewOpenGetQueueResponseQueueFilterCheckStatus.All => "all",
                QueueViewOpenGetQueueResponseQueueFilterCheckStatus.Checked => "checked",
                QueueViewOpenGetQueueResponseQueueFilterCheckStatus.Unchecked => "unchecked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetQueueResponseQueueFilterCheckStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => QueueViewOpenGetQueueResponseQueueFilterCheckStatus.All,
                "checked" => QueueViewOpenGetQueueResponseQueueFilterCheckStatus.Checked,
                "unchecked" => QueueViewOpenGetQueueResponseQueueFilterCheckStatus.Unchecked,
                _ => null,
            };
        }
    }
}