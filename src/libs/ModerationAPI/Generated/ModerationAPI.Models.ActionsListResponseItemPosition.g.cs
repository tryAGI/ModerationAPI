
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
    /// Default Value: ALL_QUEUES
    /// </summary>
    public enum ActionsListResponseItemPosition
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
    public static class ActionsListResponseItemPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListResponseItemPosition value)
        {
            return value switch
            {
                ActionsListResponseItemPosition.AllQueues => "ALL_QUEUES",
                ActionsListResponseItemPosition.Hidden => "HIDDEN",
                ActionsListResponseItemPosition.SomeQueues => "SOME_QUEUES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListResponseItemPosition? ToEnum(string value)
        {
            return value switch
            {
                "ALL_QUEUES" => ActionsListResponseItemPosition.AllQueues,
                "HIDDEN" => ActionsListResponseItemPosition.Hidden,
                "SOME_QUEUES" => ActionsListResponseItemPosition.SomeQueues,
                _ => null,
            };
        }
    }
}