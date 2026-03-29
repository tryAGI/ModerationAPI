
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The meta type of content being moderated
    /// </summary>
    public enum NewModerateModerateRequestMetaType
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
    public static class NewModerateModerateRequestMetaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateRequestMetaType value)
        {
            return value switch
            {
                NewModerateModerateRequestMetaType.Comment => "comment",
                NewModerateModerateRequestMetaType.Event => "event",
                NewModerateModerateRequestMetaType.Message => "message",
                NewModerateModerateRequestMetaType.Other => "other",
                NewModerateModerateRequestMetaType.Post => "post",
                NewModerateModerateRequestMetaType.Product => "product",
                NewModerateModerateRequestMetaType.Profile => "profile",
                NewModerateModerateRequestMetaType.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateRequestMetaType? ToEnum(string value)
        {
            return value switch
            {
                "comment" => NewModerateModerateRequestMetaType.Comment,
                "event" => NewModerateModerateRequestMetaType.Event,
                "message" => NewModerateModerateRequestMetaType.Message,
                "other" => NewModerateModerateRequestMetaType.Other,
                "post" => NewModerateModerateRequestMetaType.Post,
                "product" => NewModerateModerateRequestMetaType.Product,
                "profile" => NewModerateModerateRequestMetaType.Profile,
                "review" => NewModerateModerateRequestMetaType.Review,
                _ => null,
            };
        }
    }
}