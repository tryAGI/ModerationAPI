
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// How your recommendation combines with ours. Defaults to 'escalate', which only applies it when stricter than ours; 'override' replaces ours outright.
    /// </summary>
    public enum PublicQueueItemClientActionBehavior
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
    public static class PublicQueueItemClientActionBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicQueueItemClientActionBehavior value)
        {
            return value switch
            {
                PublicQueueItemClientActionBehavior.Escalate => "escalate",
                PublicQueueItemClientActionBehavior.Override => "override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicQueueItemClientActionBehavior? ToEnum(string value)
        {
            return value switch
            {
                "escalate" => PublicQueueItemClientActionBehavior.Escalate,
                "override" => PublicQueueItemClientActionBehavior.Override,
                _ => null,
            };
        }
    }
}