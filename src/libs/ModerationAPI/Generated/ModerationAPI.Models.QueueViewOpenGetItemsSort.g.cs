
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueViewOpenGetItemsSort
    {
        /// <summary>
        ///
        /// </summary>
        Fifo,
        /// <summary>
        ///
        /// </summary>
        Lifo,
        /// <summary>
        ///
        /// </summary>
        Random,
        /// <summary>
        ///
        /// </summary>
        SeverityDesc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetItemsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetItemsSort value)
        {
            return value switch
            {
                QueueViewOpenGetItemsSort.Fifo => "FIFO",
                QueueViewOpenGetItemsSort.Lifo => "LIFO",
                QueueViewOpenGetItemsSort.Random => "RANDOM",
                QueueViewOpenGetItemsSort.SeverityDesc => "SEVERITY_DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetItemsSort? ToEnum(string value)
        {
            return value switch
            {
                "FIFO" => QueueViewOpenGetItemsSort.Fifo,
                "LIFO" => QueueViewOpenGetItemsSort.Lifo,
                "RANDOM" => QueueViewOpenGetItemsSort.Random,
                "SEVERITY_DESC" => QueueViewOpenGetItemsSort.SeverityDesc,
                _ => null,
            };
        }
    }
}