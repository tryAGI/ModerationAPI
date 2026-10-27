
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Whether the action resolves and removes the item, unresolves and re-add it to the queue, or does not change the resolve status.<br/>
    /// Default Value: NO_CHANGE
    /// </summary>
    public enum ActionsListResponseDataItemQueueBehaviour
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
    public static class ActionsListResponseDataItemQueueBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListResponseDataItemQueueBehaviour value)
        {
            return value switch
            {
                ActionsListResponseDataItemQueueBehaviour.Add => "ADD",
                ActionsListResponseDataItemQueueBehaviour.NoChange => "NO_CHANGE",
                ActionsListResponseDataItemQueueBehaviour.Remove => "REMOVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListResponseDataItemQueueBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "ADD" => ActionsListResponseDataItemQueueBehaviour.Add,
                "NO_CHANGE" => ActionsListResponseDataItemQueueBehaviour.NoChange,
                "REMOVE" => ActionsListResponseDataItemQueueBehaviour.Remove,
                _ => null,
            };
        }
    }
}