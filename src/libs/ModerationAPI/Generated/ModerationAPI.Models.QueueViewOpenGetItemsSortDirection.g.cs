
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Sort direction<br/>
    /// Default Value: desc
    /// </summary>
    public enum QueueViewOpenGetItemsSortDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetItemsSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetItemsSortDirection value)
        {
            return value switch
            {
                QueueViewOpenGetItemsSortDirection.Asc => "asc",
                QueueViewOpenGetItemsSortDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetItemsSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => QueueViewOpenGetItemsSortDirection.Asc,
                "desc" => QueueViewOpenGetItemsSortDirection.Desc,
                _ => null,
            };
        }
    }
}