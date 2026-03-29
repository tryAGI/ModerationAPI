
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Whether the action resolves and removes the item, unresolves and re-add it to the queue, or does not change the resolve status.<br/>
    /// Default Value: NO_CHANGE
    /// </summary>
    public enum ActionsUpdateRequestQueueBehaviour
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
    public static class ActionsUpdateRequestQueueBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateRequestQueueBehaviour value)
        {
            return value switch
            {
                ActionsUpdateRequestQueueBehaviour.Add => "ADD",
                ActionsUpdateRequestQueueBehaviour.NoChange => "NO_CHANGE",
                ActionsUpdateRequestQueueBehaviour.Remove => "REMOVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateRequestQueueBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => ActionsUpdateRequestQueueBehaviour.Add,
                "NO_CHANGE" => ActionsUpdateRequestQueueBehaviour.NoChange,
                "REMOVE" => ActionsUpdateRequestQueueBehaviour.Remove,
                _ => null,
            };
        }
    }
}