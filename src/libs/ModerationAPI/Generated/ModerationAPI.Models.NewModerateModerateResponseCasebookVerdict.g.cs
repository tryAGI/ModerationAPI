
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The ruling your past decisions point to for this content.
    /// </summary>
    public enum NewModerateModerateResponseCasebookVerdict
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Reject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateResponseCasebookVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateResponseCasebookVerdict value)
        {
            return value switch
            {
                NewModerateModerateResponseCasebookVerdict.Allow => "allow",
                NewModerateModerateResponseCasebookVerdict.Reject => "reject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateResponseCasebookVerdict? ToEnum(string value)
        {
            return value switch
            {
                "allow" => NewModerateModerateResponseCasebookVerdict.Allow,
                "reject" => NewModerateModerateResponseCasebookVerdict.Reject,
                _ => null,
            };
        }
    }
}