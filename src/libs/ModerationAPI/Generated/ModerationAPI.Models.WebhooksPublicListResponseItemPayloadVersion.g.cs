
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Payload envelope version. V2 is the Stripe-style envelope; V1 is the legacy flat shape and is read-only via this API.
    /// </summary>
    public enum WebhooksPublicListResponseItemPayloadVersion
    {
        /// <summary>
        ///
        /// </summary>
        V1,
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksPublicListResponseItemPayloadVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPublicListResponseItemPayloadVersion value)
        {
            return value switch
            {
                WebhooksPublicListResponseItemPayloadVersion.V1 => "V1",
                WebhooksPublicListResponseItemPayloadVersion.V2 => "V2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPublicListResponseItemPayloadVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => WebhooksPublicListResponseItemPayloadVersion.V1,
                "V2" => WebhooksPublicListResponseItemPayloadVersion.V2,
                _ => null,
            };
        }
    }
}