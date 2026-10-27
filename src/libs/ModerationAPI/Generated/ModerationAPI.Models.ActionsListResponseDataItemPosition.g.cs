
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
    /// Default Value: ALL_QUEUES
    /// </summary>
    public enum ActionsListResponseDataItemPosition
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
    public static class ActionsListResponseDataItemPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListResponseDataItemPosition value)
        {
            return value switch
            {
                ActionsListResponseDataItemPosition.AllQueues => "ALL_QUEUES",
                ActionsListResponseDataItemPosition.Hidden => "HIDDEN",
                ActionsListResponseDataItemPosition.SomeQueues => "SOME_QUEUES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListResponseDataItemPosition? ToEnum(string value)
        {
            return value switch
            {
                "ALL_QUEUES" => ActionsListResponseDataItemPosition.AllQueues,
                "HIDDEN" => ActionsListResponseDataItemPosition.Hidden,
                "SOME_QUEUES" => ActionsListResponseDataItemPosition.SomeQueues,
                _ => null,
            };
        }
    }
}