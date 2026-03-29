
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
    /// Default Value: ALL_QUEUES
    /// </summary>
    public enum ActionsUpdateResponsePosition
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
    public static class ActionsUpdateResponsePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateResponsePosition value)
        {
            return value switch
            {
                ActionsUpdateResponsePosition.AllQueues => "ALL_QUEUES",
                ActionsUpdateResponsePosition.Hidden => "HIDDEN",
                ActionsUpdateResponsePosition.SomeQueues => "SOME_QUEUES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateResponsePosition? ToEnum(string value)
        {
            return value switch
            {
                "ALL_QUEUES" => ActionsUpdateResponsePosition.AllQueues,
                "HIDDEN" => ActionsUpdateResponsePosition.Hidden,
                "SOME_QUEUES" => ActionsUpdateResponsePosition.SomeQueues,
                _ => null,
            };
        }
    }
}