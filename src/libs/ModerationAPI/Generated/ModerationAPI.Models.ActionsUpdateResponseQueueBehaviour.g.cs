
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Whether the action resolves and removes the item, unresolves and re-add it to the queue, or does not change the resolve status.<br/>
    /// Default Value: NO_CHANGE
    /// </summary>
    public enum ActionsUpdateResponseQueueBehaviour
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
    public static class ActionsUpdateResponseQueueBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateResponseQueueBehaviour value)
        {
            return value switch
            {
                ActionsUpdateResponseQueueBehaviour.Add => "ADD",
                ActionsUpdateResponseQueueBehaviour.NoChange => "NO_CHANGE",
                ActionsUpdateResponseQueueBehaviour.Remove => "REMOVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateResponseQueueBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => ActionsUpdateResponseQueueBehaviour.Add,
                "NO_CHANGE" => ActionsUpdateResponseQueueBehaviour.NoChange,
                "REMOVE" => ActionsUpdateResponseQueueBehaviour.Remove,
                _ => null,
            };
        }
    }
}