
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksPublicGetResponseEventType
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
    public static class WebhooksPublicGetResponseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPublicGetResponseEventType value)
        {
            return value switch
            {
                WebhooksPublicGetResponseEventType.AuthorAction => "AUTHOR_ACTION",
                WebhooksPublicGetResponseEventType.AuthorBlocked => "AUTHOR_BLOCKED",
                WebhooksPublicGetResponseEventType.AuthorSuspended => "AUTHOR_SUSPENDED",
                WebhooksPublicGetResponseEventType.AuthorTrustLevelChanged => "AUTHOR_TRUST_LEVEL_CHANGED",
                WebhooksPublicGetResponseEventType.AuthorUnblocked => "AUTHOR_UNBLOCKED",
                WebhooksPublicGetResponseEventType.AuthorUpdated => "AUTHOR_UPDATED",
                WebhooksPublicGetResponseEventType.QueueItemAction => "QUEUE_ITEM_ACTION",
                WebhooksPublicGetResponseEventType.QueueItemAllowed => "QUEUE_ITEM_ALLOWED",
                WebhooksPublicGetResponseEventType.QueueItemCompleted => "QUEUE_ITEM_COMPLETED",
                WebhooksPublicGetResponseEventType.QueueItemNew => "QUEUE_ITEM_NEW",
                WebhooksPublicGetResponseEventType.QueueItemRejected => "QUEUE_ITEM_REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPublicGetResponseEventType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_ACTION" => WebhooksPublicGetResponseEventType.AuthorAction,
                "AUTHOR_BLOCKED" => WebhooksPublicGetResponseEventType.AuthorBlocked,
                "AUTHOR_SUSPENDED" => WebhooksPublicGetResponseEventType.AuthorSuspended,
                "AUTHOR_TRUST_LEVEL_CHANGED" => WebhooksPublicGetResponseEventType.AuthorTrustLevelChanged,
                "AUTHOR_UNBLOCKED" => WebhooksPublicGetResponseEventType.AuthorUnblocked,
                "AUTHOR_UPDATED" => WebhooksPublicGetResponseEventType.AuthorUpdated,
                "QUEUE_ITEM_ACTION" => WebhooksPublicGetResponseEventType.QueueItemAction,
                "QUEUE_ITEM_ALLOWED" => WebhooksPublicGetResponseEventType.QueueItemAllowed,
                "QUEUE_ITEM_COMPLETED" => WebhooksPublicGetResponseEventType.QueueItemCompleted,
                "QUEUE_ITEM_NEW" => WebhooksPublicGetResponseEventType.QueueItemNew,
                "QUEUE_ITEM_REJECTED" => WebhooksPublicGetResponseEventType.QueueItemRejected,
                _ => null,
            };
        }
    }
}