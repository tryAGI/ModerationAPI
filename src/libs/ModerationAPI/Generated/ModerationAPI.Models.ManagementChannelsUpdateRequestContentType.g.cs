
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The kind of content the channel moderates.
    /// </summary>
    public enum ManagementChannelsUpdateRequestContentType
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
    public static class ManagementChannelsUpdateRequestContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagementChannelsUpdateRequestContentType value)
        {
            return value switch
            {
                ManagementChannelsUpdateRequestContentType.Comment => "comment",
                ManagementChannelsUpdateRequestContentType.Event => "event",
                ManagementChannelsUpdateRequestContentType.Message => "message",
                ManagementChannelsUpdateRequestContentType.Other => "other",
                ManagementChannelsUpdateRequestContentType.Post => "post",
                ManagementChannelsUpdateRequestContentType.Product => "product",
                ManagementChannelsUpdateRequestContentType.Profile => "profile",
                ManagementChannelsUpdateRequestContentType.Review => "review",
                ManagementChannelsUpdateRequestContentType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagementChannelsUpdateRequestContentType? ToEnum(string value)
        {
            return value switch
            {
                "comment" => ManagementChannelsUpdateRequestContentType.Comment,
                "event" => ManagementChannelsUpdateRequestContentType.Event,
                "message" => ManagementChannelsUpdateRequestContentType.Message,
                "other" => ManagementChannelsUpdateRequestContentType.Other,
                "post" => ManagementChannelsUpdateRequestContentType.Post,
                "product" => ManagementChannelsUpdateRequestContentType.Product,
                "profile" => ManagementChannelsUpdateRequestContentType.Profile,
                "review" => ManagementChannelsUpdateRequestContentType.Review,
                "voice" => ManagementChannelsUpdateRequestContentType.Voice,
                _ => null,
            };
        }
    }
}