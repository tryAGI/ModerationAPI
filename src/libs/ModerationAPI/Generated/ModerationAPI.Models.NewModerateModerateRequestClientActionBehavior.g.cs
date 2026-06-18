
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// How your recommendation combines with ours. Defaults to 'escalate', which only applies it when stricter than ours; 'override' replaces ours outright.
    /// </summary>
    public enum NewModerateModerateRequestClientActionBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        Escalate,
        /// <summary>
        /// 
        /// </summary>
        Override,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewModerateModerateRequestClientActionBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewModerateModerateRequestClientActionBehavior value)
        {
            return value switch
            {
                NewModerateModerateRequestClientActionBehavior.Escalate => "escalate",
                NewModerateModerateRequestClientActionBehavior.Override => "override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewModerateModerateRequestClientActionBehavior? ToEnum(string value)
        {
            return value switch
            {
                "escalate" => NewModerateModerateRequestClientActionBehavior.Escalate,
                "override" => NewModerateModerateRequestClientActionBehavior.Override,
                _ => null,
            };
        }
    }
}