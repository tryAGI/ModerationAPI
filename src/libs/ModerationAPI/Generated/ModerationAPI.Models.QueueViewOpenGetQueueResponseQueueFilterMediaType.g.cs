
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum QueueViewOpenGetQueueResponseQueueFilterMediaType
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Object,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueueViewOpenGetQueueResponseQueueFilterMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueueViewOpenGetQueueResponseQueueFilterMediaType value)
        {
            return value switch
            {
                QueueViewOpenGetQueueResponseQueueFilterMediaType.Audio => "audio",
                QueueViewOpenGetQueueResponseQueueFilterMediaType.Image => "image",
                QueueViewOpenGetQueueResponseQueueFilterMediaType.Object => "object",
                QueueViewOpenGetQueueResponseQueueFilterMediaType.Text => "text",
                QueueViewOpenGetQueueResponseQueueFilterMediaType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueueViewOpenGetQueueResponseQueueFilterMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => QueueViewOpenGetQueueResponseQueueFilterMediaType.Audio,
                "image" => QueueViewOpenGetQueueResponseQueueFilterMediaType.Image,
                "object" => QueueViewOpenGetQueueResponseQueueFilterMediaType.Object,
                "text" => QueueViewOpenGetQueueResponseQueueFilterMediaType.Text,
                "video" => QueueViewOpenGetQueueResponseQueueFilterMediaType.Video,
                _ => null,
            };
        }
    }
}