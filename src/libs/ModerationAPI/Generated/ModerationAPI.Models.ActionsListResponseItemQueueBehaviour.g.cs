
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Whether the action resolves and removes the item, unresolves and re-add it to the queue, or does not change the resolve status.<br/>
    /// Default Value: NO_CHANGE
    /// </summary>
    public enum ActionsListResponseItemQueueBehaviour
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        NoChange,
        /// <summary>
        /// 
        /// </summary>
        Remove,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsListResponseItemQueueBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListResponseItemQueueBehaviour value)
        {
            return value switch
            {
                ActionsListResponseItemQueueBehaviour.Add => "ADD",
                ActionsListResponseItemQueueBehaviour.NoChange => "NO_CHANGE",
                ActionsListResponseItemQueueBehaviour.Remove => "REMOVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListResponseItemQueueBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => ActionsListResponseItemQueueBehaviour.Add,
                "NO_CHANGE" => ActionsListResponseItemQueueBehaviour.NoChange,
                "REMOVE" => ActionsListResponseItemQueueBehaviour.Remove,
                _ => null,
            };
        }
    }
}