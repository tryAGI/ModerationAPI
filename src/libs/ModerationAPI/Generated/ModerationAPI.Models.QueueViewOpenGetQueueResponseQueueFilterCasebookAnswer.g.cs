
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Allowed,
        /// <summary>
        ///
        /// </summary>
        NoAnswer,
        /// <summary>
        ///
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetQueueResponseQueueFilterCasebookAnswerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer value)
        {
            return value switch
            {
                QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer.All => "ALL",
                QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer.Allowed => "ALLOWED",
                QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer.NoAnswer => "NO_ANSWER",
                QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer.Rejected => "REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer.All,
                "ALLOWED" => QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer.Allowed,
                "NO_ANSWER" => QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer.NoAnswer,
                "REJECTED" => QueueViewOpenGetQueueResponseQueueFilterCasebookAnswer.Rejected,
                _ => null,
            };
        }
    }
}