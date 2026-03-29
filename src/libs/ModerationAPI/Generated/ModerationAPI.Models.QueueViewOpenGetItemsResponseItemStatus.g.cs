
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Status of the item
    /// </summary>
    public enum QueueViewOpenGetItemsResponseItemStatus
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
    public static class QueueViewOpenGetItemsResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetItemsResponseItemStatus value)
        {
            return value switch
            {
                QueueViewOpenGetItemsResponseItemStatus.Pending => "pending",
                QueueViewOpenGetItemsResponseItemStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetItemsResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => QueueViewOpenGetItemsResponseItemStatus.Pending,
                "resolved" => QueueViewOpenGetItemsResponseItemStatus.Resolved,
                _ => null,
            };
        }
    }
}