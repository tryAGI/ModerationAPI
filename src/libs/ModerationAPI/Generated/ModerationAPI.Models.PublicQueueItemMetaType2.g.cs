
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublicQueueItemMetaType2
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicQueueItemMetaType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicQueueItemMetaType2 value)
        {
            return value switch
            {
                PublicQueueItemMetaType2.Comment => "comment",
                PublicQueueItemMetaType2.Event => "event",
                PublicQueueItemMetaType2.Message => "message",
                PublicQueueItemMetaType2.Other => "other",
                PublicQueueItemMetaType2.Post => "post",
                PublicQueueItemMetaType2.Product => "product",
                PublicQueueItemMetaType2.Profile => "profile",
                PublicQueueItemMetaType2.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicQueueItemMetaType2? ToEnum(string value)
        {
            return value switch
            {
                "comment" => PublicQueueItemMetaType2.Comment,
                "event" => PublicQueueItemMetaType2.Event,
                "message" => PublicQueueItemMetaType2.Message,
                "other" => PublicQueueItemMetaType2.Other,
                "post" => PublicQueueItemMetaType2.Post,
                "product" => PublicQueueItemMetaType2.Product,
                "profile" => PublicQueueItemMetaType2.Profile,
                "review" => PublicQueueItemMetaType2.Review,
                _ => null,
            };
        }
    }
}