
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksPublicCreateResponseEventType
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
    public static class WebhooksPublicCreateResponseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPublicCreateResponseEventType value)
        {
            return value switch
            {
                WebhooksPublicCreateResponseEventType.AuthorAction => "AUTHOR_ACTION",
                WebhooksPublicCreateResponseEventType.AuthorBlocked => "AUTHOR_BLOCKED",
                WebhooksPublicCreateResponseEventType.AuthorSuspended => "AUTHOR_SUSPENDED",
                WebhooksPublicCreateResponseEventType.AuthorTrustLevelChanged => "AUTHOR_TRUST_LEVEL_CHANGED",
                WebhooksPublicCreateResponseEventType.AuthorUnblocked => "AUTHOR_UNBLOCKED",
                WebhooksPublicCreateResponseEventType.AuthorUpdated => "AUTHOR_UPDATED",
                WebhooksPublicCreateResponseEventType.QueueItemAction => "QUEUE_ITEM_ACTION",
                WebhooksPublicCreateResponseEventType.QueueItemAllowed => "QUEUE_ITEM_ALLOWED",
                WebhooksPublicCreateResponseEventType.QueueItemCompleted => "QUEUE_ITEM_COMPLETED",
                WebhooksPublicCreateResponseEventType.QueueItemNew => "QUEUE_ITEM_NEW",
                WebhooksPublicCreateResponseEventType.QueueItemRejected => "QUEUE_ITEM_REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPublicCreateResponseEventType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_ACTION" => WebhooksPublicCreateResponseEventType.AuthorAction,
                "AUTHOR_BLOCKED" => WebhooksPublicCreateResponseEventType.AuthorBlocked,
                "AUTHOR_SUSPENDED" => WebhooksPublicCreateResponseEventType.AuthorSuspended,
                "AUTHOR_TRUST_LEVEL_CHANGED" => WebhooksPublicCreateResponseEventType.AuthorTrustLevelChanged,
                "AUTHOR_UNBLOCKED" => WebhooksPublicCreateResponseEventType.AuthorUnblocked,
                "AUTHOR_UPDATED" => WebhooksPublicCreateResponseEventType.AuthorUpdated,
                "QUEUE_ITEM_ACTION" => WebhooksPublicCreateResponseEventType.QueueItemAction,
                "QUEUE_ITEM_ALLOWED" => WebhooksPublicCreateResponseEventType.QueueItemAllowed,
                "QUEUE_ITEM_COMPLETED" => WebhooksPublicCreateResponseEventType.QueueItemCompleted,
                "QUEUE_ITEM_NEW" => WebhooksPublicCreateResponseEventType.QueueItemNew,
                "QUEUE_ITEM_REJECTED" => WebhooksPublicCreateResponseEventType.QueueItemRejected,
                _ => null,
            };
        }
    }
}