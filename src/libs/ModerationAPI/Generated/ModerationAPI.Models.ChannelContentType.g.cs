
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The kind of content the channel moderates.
    /// </summary>
    public enum ChannelContentType
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
    public static class ChannelContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelContentType value)
        {
            return value switch
            {
                ChannelContentType.Comment => "comment",
                ChannelContentType.Event => "event",
                ChannelContentType.Message => "message",
                ChannelContentType.Other => "other",
                ChannelContentType.Post => "post",
                ChannelContentType.Product => "product",
                ChannelContentType.Profile => "profile",
                ChannelContentType.Review => "review",
                ChannelContentType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelContentType? ToEnum(string value)
        {
            return value switch
            {
                "comment" => ChannelContentType.Comment,
                "event" => ChannelContentType.Event,
                "message" => ChannelContentType.Message,
                "other" => ChannelContentType.Other,
                "post" => ChannelContentType.Post,
                "product" => ChannelContentType.Product,
                "profile" => ChannelContentType.Profile,
                "review" => ChannelContentType.Review,
                "voice" => ChannelContentType.Voice,
                _ => null,
            };
        }
    }
}