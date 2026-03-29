
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Whether the action resolves and removes the item, unresolves and re-add it to the queue, or does not change the resolve status.<br/>
    /// Default Value: NO_CHANGE
    /// </summary>
    public enum ActionsGetResponseQueueBehaviour
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
    public static class ActionsGetResponseQueueBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsGetResponseQueueBehaviour value)
        {
            return value switch
            {
                ActionsGetResponseQueueBehaviour.Add => "ADD",
                ActionsGetResponseQueueBehaviour.NoChange => "NO_CHANGE",
                ActionsGetResponseQueueBehaviour.Remove => "REMOVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsGetResponseQueueBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => ActionsGetResponseQueueBehaviour.Add,
                "NO_CHANGE" => ActionsGetResponseQueueBehaviour.NoChange,
                "REMOVE" => ActionsGetResponseQueueBehaviour.Remove,
                _ => null,
            };
        }
    }
}