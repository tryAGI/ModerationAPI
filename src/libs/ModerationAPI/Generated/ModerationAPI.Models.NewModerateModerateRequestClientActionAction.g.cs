
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Your recommendation for the content: allow, review, or reject.
    /// </summary>
    public enum NewModerateModerateRequestClientActionAction
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
    public static class NewModerateModerateRequestClientActionActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateRequestClientActionAction value)
        {
            return value switch
            {
                NewModerateModerateRequestClientActionAction.Allow => "allow",
                NewModerateModerateRequestClientActionAction.Reject => "reject",
                NewModerateModerateRequestClientActionAction.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateRequestClientActionAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => NewModerateModerateRequestClientActionAction.Allow,
                "reject" => NewModerateModerateRequestClientActionAction.Reject,
                "review" => NewModerateModerateRequestClientActionAction.Review,
                _ => null,
            };
        }
    }
}