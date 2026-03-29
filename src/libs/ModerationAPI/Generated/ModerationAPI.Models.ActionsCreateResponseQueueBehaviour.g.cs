
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Whether the action resolves and removes the item, unresolves and re-add it to the queue, or does not change the resolve status.<br/>
    /// Default Value: NO_CHANGE
    /// </summary>
    public enum ActionsCreateResponseQueueBehaviour
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
    public static class ActionsCreateResponseQueueBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateResponseQueueBehaviour value)
        {
            return value switch
            {
                ActionsCreateResponseQueueBehaviour.Add => "ADD",
                ActionsCreateResponseQueueBehaviour.NoChange => "NO_CHANGE",
                ActionsCreateResponseQueueBehaviour.Remove => "REMOVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateResponseQueueBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => ActionsCreateResponseQueueBehaviour.Add,
                "NO_CHANGE" => ActionsCreateResponseQueueBehaviour.NoChange,
                "REMOVE" => ActionsCreateResponseQueueBehaviour.Remove,
                _ => null,
            };
        }
    }
}