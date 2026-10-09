
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksPublicCreateRequestEventType
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
    public static class WebhooksPublicCreateRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPublicCreateRequestEventType value)
        {
            return value switch
            {
                WebhooksPublicCreateRequestEventType.AuthorAction => "AUTHOR_ACTION",
                WebhooksPublicCreateRequestEventType.AuthorBlocked => "AUTHOR_BLOCKED",
                WebhooksPublicCreateRequestEventType.AuthorSuspended => "AUTHOR_SUSPENDED",
                WebhooksPublicCreateRequestEventType.AuthorTrustLevelChanged => "AUTHOR_TRUST_LEVEL_CHANGED",
                WebhooksPublicCreateRequestEventType.AuthorUnblocked => "AUTHOR_UNBLOCKED",
                WebhooksPublicCreateRequestEventType.AuthorUpdated => "AUTHOR_UPDATED",
                WebhooksPublicCreateRequestEventType.QueueItemAction => "QUEUE_ITEM_ACTION",
                WebhooksPublicCreateRequestEventType.QueueItemAllowed => "QUEUE_ITEM_ALLOWED",
                WebhooksPublicCreateRequestEventType.QueueItemCompleted => "QUEUE_ITEM_COMPLETED",
                WebhooksPublicCreateRequestEventType.QueueItemNew => "QUEUE_ITEM_NEW",
                WebhooksPublicCreateRequestEventType.QueueItemRejected => "QUEUE_ITEM_REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPublicCreateRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_ACTION" => WebhooksPublicCreateRequestEventType.AuthorAction,
                "AUTHOR_BLOCKED" => WebhooksPublicCreateRequestEventType.AuthorBlocked,
                "AUTHOR_SUSPENDED" => WebhooksPublicCreateRequestEventType.AuthorSuspended,
                "AUTHOR_TRUST_LEVEL_CHANGED" => WebhooksPublicCreateRequestEventType.AuthorTrustLevelChanged,
                "AUTHOR_UNBLOCKED" => WebhooksPublicCreateRequestEventType.AuthorUnblocked,
                "AUTHOR_UPDATED" => WebhooksPublicCreateRequestEventType.AuthorUpdated,
                "QUEUE_ITEM_ACTION" => WebhooksPublicCreateRequestEventType.QueueItemAction,
                "QUEUE_ITEM_ALLOWED" => WebhooksPublicCreateRequestEventType.QueueItemAllowed,
                "QUEUE_ITEM_COMPLETED" => WebhooksPublicCreateRequestEventType.QueueItemCompleted,
                "QUEUE_ITEM_NEW" => WebhooksPublicCreateRequestEventType.QueueItemNew,
                "QUEUE_ITEM_REJECTED" => WebhooksPublicCreateRequestEventType.QueueItemRejected,
                _ => null,
            };
        }
    }
}