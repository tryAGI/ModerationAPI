
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
    /// Default Value: ALL_QUEUES
    /// </summary>
    public enum ActionsGetResponsePosition
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
    public static class ActionsGetResponsePositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsGetResponsePosition value)
        {
            return value switch
            {
                ActionsGetResponsePosition.AllQueues => "ALL_QUEUES",
                ActionsGetResponsePosition.Hidden => "HIDDEN",
                ActionsGetResponsePosition.SomeQueues => "SOME_QUEUES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsGetResponsePosition? ToEnum(string value)
        {
            return value switch
            {
                "ALL_QUEUES" => ActionsGetResponsePosition.AllQueues,
                "HIDDEN" => ActionsGetResponsePosition.Hidden,
                "SOME_QUEUES" => ActionsGetResponsePosition.SomeQueues,
                _ => null,
            };
        }
    }
}