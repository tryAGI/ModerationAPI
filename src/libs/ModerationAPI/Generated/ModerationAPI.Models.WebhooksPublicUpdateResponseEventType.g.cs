
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksPublicUpdateResponseEventType
    {
        /// <summary>
        ///
        /// </summary>
        AuthorAction,
        /// <summary>
        ///
        /// </summary>
        AuthorBlocked,
        /// <summary>
        ///
        /// </summary>
        AuthorSuspended,
        /// <summary>
        ///
        /// </summary>
        AuthorTrustLevelChanged,
        /// <summary>
        ///
        /// </summary>
        AuthorUnblocked,
        /// <summary>
        ///
        /// </summary>
        AuthorUpdated,
        /// <summary>
        ///
        /// </summary>
        QueueItemAction,
        /// <summary>
        ///
        /// </summary>
        QueueItemAllowed,
        /// <summary>
        ///
        /// </summary>
        QueueItemCompleted,
        /// <summary>
        ///
        /// </summary>
        QueueItemNew,
        /// <summary>
        ///
        /// </summary>
        QueueItemRejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksPublicUpdateResponseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPublicUpdateResponseEventType value)
        {
            return value switch
            {
                WebhooksPublicUpdateResponseEventType.AuthorAction => "AUTHOR_ACTION",
                WebhooksPublicUpdateResponseEventType.AuthorBlocked => "AUTHOR_BLOCKED",
                WebhooksPublicUpdateResponseEventType.AuthorSuspended => "AUTHOR_SUSPENDED",
                WebhooksPublicUpdateResponseEventType.AuthorTrustLevelChanged => "AUTHOR_TRUST_LEVEL_CHANGED",
                WebhooksPublicUpdateResponseEventType.AuthorUnblocked => "AUTHOR_UNBLOCKED",
                WebhooksPublicUpdateResponseEventType.AuthorUpdated => "AUTHOR_UPDATED",
                WebhooksPublicUpdateResponseEventType.QueueItemAction => "QUEUE_ITEM_ACTION",
                WebhooksPublicUpdateResponseEventType.QueueItemAllowed => "QUEUE_ITEM_ALLOWED",
                WebhooksPublicUpdateResponseEventType.QueueItemCompleted => "QUEUE_ITEM_COMPLETED",
                WebhooksPublicUpdateResponseEventType.QueueItemNew => "QUEUE_ITEM_NEW",
                WebhooksPublicUpdateResponseEventType.QueueItemRejected => "QUEUE_ITEM_REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPublicUpdateResponseEventType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_ACTION" => WebhooksPublicUpdateResponseEventType.AuthorAction,
                "AUTHOR_BLOCKED" => WebhooksPublicUpdateResponseEventType.AuthorBlocked,
                "AUTHOR_SUSPENDED" => WebhooksPublicUpdateResponseEventType.AuthorSuspended,
                "AUTHOR_TRUST_LEVEL_CHANGED" => WebhooksPublicUpdateResponseEventType.AuthorTrustLevelChanged,
                "AUTHOR_UNBLOCKED" => WebhooksPublicUpdateResponseEventType.AuthorUnblocked,
                "AUTHOR_UPDATED" => WebhooksPublicUpdateResponseEventType.AuthorUpdated,
                "QUEUE_ITEM_ACTION" => WebhooksPublicUpdateResponseEventType.QueueItemAction,
                "QUEUE_ITEM_ALLOWED" => WebhooksPublicUpdateResponseEventType.QueueItemAllowed,
                "QUEUE_ITEM_COMPLETED" => WebhooksPublicUpdateResponseEventType.QueueItemCompleted,
                "QUEUE_ITEM_NEW" => WebhooksPublicUpdateResponseEventType.QueueItemNew,
                "QUEUE_ITEM_REJECTED" => WebhooksPublicUpdateResponseEventType.QueueItemRejected,
                _ => null,
            };
        }
    }
}