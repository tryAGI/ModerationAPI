
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Your recommendation for the content: allow, review, or reject.
    /// </summary>
    public enum PublicQueueItemClientActionAction
    {
        /// <summary>
        /// allow, review, or reject.
        /// </summary>
        Allow,
        /// <summary>
        /// allow, review, or reject.
        /// </summary>
        Reject,
        /// <summary>
        /// allow, review, or reject.
        /// </summary>
        Review,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicQueueItemClientActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicQueueItemClientActionAction value)
        {
            return value switch
            {
                PublicQueueItemClientActionAction.Allow => "allow",
                PublicQueueItemClientActionAction.Reject => "reject",
                PublicQueueItemClientActionAction.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicQueueItemClientActionAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => PublicQueueItemClientActionAction.Allow,
                "reject" => PublicQueueItemClientActionAction.Reject,
                "review" => PublicQueueItemClientActionAction.Review,
                _ => null,
            };
        }
    }
}