
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueViewOpenGetQueueResponseQueueFilterContentType
    {
        /// <summary>
        ///
        /// </summary>
        Comment,
        /// <summary>
        ///
        /// </summary>
        Event,
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        Post,
        /// <summary>
        ///
        /// </summary>
        Product,
        /// <summary>
        ///
        /// </summary>
        Profile,
        /// <summary>
        ///
        /// </summary>
        Review,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetQueueResponseQueueFilterContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetQueueResponseQueueFilterContentType value)
        {
            return value switch
            {
                QueueViewOpenGetQueueResponseQueueFilterContentType.Comment => "comment",
                QueueViewOpenGetQueueResponseQueueFilterContentType.Event => "event",
                QueueViewOpenGetQueueResponseQueueFilterContentType.Message => "message",
                QueueViewOpenGetQueueResponseQueueFilterContentType.Other => "other",
                QueueViewOpenGetQueueResponseQueueFilterContentType.Post => "post",
                QueueViewOpenGetQueueResponseQueueFilterContentType.Product => "product",
                QueueViewOpenGetQueueResponseQueueFilterContentType.Profile => "profile",
                QueueViewOpenGetQueueResponseQueueFilterContentType.Review => "review",
                QueueViewOpenGetQueueResponseQueueFilterContentType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetQueueResponseQueueFilterContentType? ToEnum(string value)
        {
            return value switch
            {
                "comment" => QueueViewOpenGetQueueResponseQueueFilterContentType.Comment,
                "event" => QueueViewOpenGetQueueResponseQueueFilterContentType.Event,
                "message" => QueueViewOpenGetQueueResponseQueueFilterContentType.Message,
                "other" => QueueViewOpenGetQueueResponseQueueFilterContentType.Other,
                "post" => QueueViewOpenGetQueueResponseQueueFilterContentType.Post,
                "product" => QueueViewOpenGetQueueResponseQueueFilterContentType.Product,
                "profile" => QueueViewOpenGetQueueResponseQueueFilterContentType.Profile,
                "review" => QueueViewOpenGetQueueResponseQueueFilterContentType.Review,
                "voice" => QueueViewOpenGetQueueResponseQueueFilterContentType.Voice,
                _ => null,
            };
        }
    }
}