
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum PublicQueueItemMetaType
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
    public static class PublicQueueItemMetaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicQueueItemMetaType value)
        {
            return value switch
            {
                PublicQueueItemMetaType.Comment => "comment",
                PublicQueueItemMetaType.Event => "event",
                PublicQueueItemMetaType.Message => "message",
                PublicQueueItemMetaType.Other => "other",
                PublicQueueItemMetaType.Post => "post",
                PublicQueueItemMetaType.Product => "product",
                PublicQueueItemMetaType.Profile => "profile",
                PublicQueueItemMetaType.Review => "review",
                PublicQueueItemMetaType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicQueueItemMetaType? ToEnum(string value)
        {
            return value switch
            {
                "comment" => PublicQueueItemMetaType.Comment,
                "event" => PublicQueueItemMetaType.Event,
                "message" => PublicQueueItemMetaType.Message,
                "other" => PublicQueueItemMetaType.Other,
                "post" => PublicQueueItemMetaType.Post,
                "product" => PublicQueueItemMetaType.Product,
                "profile" => PublicQueueItemMetaType.Profile,
                "review" => PublicQueueItemMetaType.Review,
                "voice" => PublicQueueItemMetaType.Voice,
                _ => null,
            };
        }
    }
}