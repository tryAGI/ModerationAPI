
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The kind of content the channel moderates.
    /// </summary>
    public enum ManagementChannelsCreateRequestContentType
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
    public static class ManagementChannelsCreateRequestContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagementChannelsCreateRequestContentType value)
        {
            return value switch
            {
                ManagementChannelsCreateRequestContentType.Comment => "comment",
                ManagementChannelsCreateRequestContentType.Event => "event",
                ManagementChannelsCreateRequestContentType.Message => "message",
                ManagementChannelsCreateRequestContentType.Other => "other",
                ManagementChannelsCreateRequestContentType.Post => "post",
                ManagementChannelsCreateRequestContentType.Product => "product",
                ManagementChannelsCreateRequestContentType.Profile => "profile",
                ManagementChannelsCreateRequestContentType.Review => "review",
                ManagementChannelsCreateRequestContentType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagementChannelsCreateRequestContentType? ToEnum(string value)
        {
            return value switch
            {
                "comment" => ManagementChannelsCreateRequestContentType.Comment,
                "event" => ManagementChannelsCreateRequestContentType.Event,
                "message" => ManagementChannelsCreateRequestContentType.Message,
                "other" => ManagementChannelsCreateRequestContentType.Other,
                "post" => ManagementChannelsCreateRequestContentType.Post,
                "product" => ManagementChannelsCreateRequestContentType.Product,
                "profile" => ManagementChannelsCreateRequestContentType.Profile,
                "review" => ManagementChannelsCreateRequestContentType.Review,
                "voice" => ManagementChannelsCreateRequestContentType.Voice,
                _ => null,
            };
        }
    }
}