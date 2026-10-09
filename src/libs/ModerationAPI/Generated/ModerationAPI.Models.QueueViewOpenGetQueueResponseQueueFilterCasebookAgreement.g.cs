
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement
    {
        /// <summary>
        ///
        /// </summary>
        Agreed,
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Overruled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetQueueResponseQueueFilterCasebookAgreementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement value)
        {
            return value switch
            {
                QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement.Agreed => "AGREED",
                QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement.All => "ALL",
                QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement.Overruled => "OVERRULED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement? ToEnum(string value)
        {
            return value switch
            {
                "AGREED" => QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement.Agreed,
                "ALL" => QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement.All,
                "OVERRULED" => QueueViewOpenGetQueueResponseQueueFilterCasebookAgreement.Overruled,
                _ => null,
            };
        }
    }
}