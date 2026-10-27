
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `pending` waits for review. `resolved` is reviewed.
    /// </summary>
    public enum QueueItemStatus
    {
        /// <summary>
        ///
        /// </summary>
        Pending,
        /// <summary>
        ///
        /// </summary>
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueItemStatus value)
        {
            return value switch
            {
                QueueItemStatus.Pending => "pending",
                QueueItemStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => QueueItemStatus.Pending,
                "resolved" => QueueItemStatus.Resolved,
                _ => null,
            };
        }
    }
}