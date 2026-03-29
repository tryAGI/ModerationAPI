
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
    /// Default Value: ALL_QUEUES
    /// </summary>
    public enum ActionsCreateRequestPosition
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
    public static class ActionsCreateRequestPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateRequestPosition value)
        {
            return value switch
            {
                ActionsCreateRequestPosition.AllQueues => "ALL_QUEUES",
                ActionsCreateRequestPosition.Hidden => "HIDDEN",
                ActionsCreateRequestPosition.SomeQueues => "SOME_QUEUES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateRequestPosition? ToEnum(string value)
        {
            return value switch
            {
                "ALL_QUEUES" => ActionsCreateRequestPosition.AllQueues,
                "HIDDEN" => ActionsCreateRequestPosition.Hidden,
                "SOME_QUEUES" => ActionsCreateRequestPosition.SomeQueues,
                _ => null,
            };
        }
    }
}