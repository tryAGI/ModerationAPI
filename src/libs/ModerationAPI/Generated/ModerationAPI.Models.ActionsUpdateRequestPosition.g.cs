
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
    /// Default Value: ALL_QUEUES
    /// </summary>
    public enum ActionsUpdateRequestPosition
    {
        /// <summary>
        /// 
        /// </summary>
        AllQueues,
        /// <summary>
        /// 
        /// </summary>
        Hidden,
        /// <summary>
        /// 
        /// </summary>
        SomeQueues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsUpdateRequestPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateRequestPosition value)
        {
            return value switch
            {
                ActionsUpdateRequestPosition.AllQueues => "ALL_QUEUES",
                ActionsUpdateRequestPosition.Hidden => "HIDDEN",
                ActionsUpdateRequestPosition.SomeQueues => "SOME_QUEUES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateRequestPosition? ToEnum(string value)
        {
            return value switch
            {
                "ALL_QUEUES" => ActionsUpdateRequestPosition.AllQueues,
                "HIDDEN" => ActionsUpdateRequestPosition.Hidden,
                "SOME_QUEUES" => ActionsUpdateRequestPosition.SomeQueues,
                _ => null,
            };
        }
    }
}