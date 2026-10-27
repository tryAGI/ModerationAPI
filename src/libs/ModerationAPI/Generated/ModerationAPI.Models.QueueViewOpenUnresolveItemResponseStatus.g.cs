
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `pending` waits for review. `resolved` is reviewed.
    /// </summary>
    public enum QueueViewOpenUnresolveItemResponseStatus
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
    public static class QueueViewOpenUnresolveItemResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenUnresolveItemResponseStatus value)
        {
            return value switch
            {
                QueueViewOpenUnresolveItemResponseStatus.Pending => "pending",
                QueueViewOpenUnresolveItemResponseStatus.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenUnresolveItemResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => QueueViewOpenUnresolveItemResponseStatus.Pending,
                "resolved" => QueueViewOpenUnresolveItemResponseStatus.Resolved,
                _ => null,
            };
        }
    }
}