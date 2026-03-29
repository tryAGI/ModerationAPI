
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueueViewOpenGetItemsSortField
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        ReviewedAt,
        /// <summary>
        /// 
        /// </summary>
        Severity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetItemsSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetItemsSortField value)
        {
            return value switch
            {
                QueueViewOpenGetItemsSortField.CreatedAt => "createdAt",
                QueueViewOpenGetItemsSortField.ReviewedAt => "reviewedAt",
                QueueViewOpenGetItemsSortField.Severity => "severity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetItemsSortField? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => QueueViewOpenGetItemsSortField.CreatedAt,
                "reviewedAt" => QueueViewOpenGetItemsSortField.ReviewedAt,
                "severity" => QueueViewOpenGetItemsSortField.Severity,
                _ => null,
            };
        }
    }
}