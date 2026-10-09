
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueViewOpenGetQueueResponseQueueFilterWithinUnit
    {
        /// <summary>
        ///
        /// </summary>
        Days,
        /// <summary>
        ///
        /// </summary>
        Hours,
        /// <summary>
        ///
        /// </summary>
        Minutes,
        /// <summary>
        ///
        /// </summary>
        Months,
        /// <summary>
        ///
        /// </summary>
        Weeks,
        /// <summary>
        ///
        /// </summary>
        Years,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetQueueResponseQueueFilterWithinUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetQueueResponseQueueFilterWithinUnit value)
        {
            return value switch
            {
                QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Days => "DAYS",
                QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Hours => "HOURS",
                QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Minutes => "MINUTES",
                QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Months => "MONTHS",
                QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Weeks => "WEEKS",
                QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Years => "YEARS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetQueueResponseQueueFilterWithinUnit? ToEnum(string value)
        {
            return value switch
            {
                "DAYS" => QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Days,
                "HOURS" => QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Hours,
                "MINUTES" => QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Minutes,
                "MONTHS" => QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Months,
                "WEEKS" => QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Weeks,
                "YEARS" => QueueViewOpenGetQueueResponseQueueFilterWithinUnit.Years,
                _ => null,
            };
        }
    }
}