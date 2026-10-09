
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksPublicUpdateRequestEventType
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
    public static class WebhooksPublicUpdateRequestEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPublicUpdateRequestEventType value)
        {
            return value switch
            {
                WebhooksPublicUpdateRequestEventType.AuthorAction => "AUTHOR_ACTION",
                WebhooksPublicUpdateRequestEventType.AuthorBlocked => "AUTHOR_BLOCKED",
                WebhooksPublicUpdateRequestEventType.AuthorSuspended => "AUTHOR_SUSPENDED",
                WebhooksPublicUpdateRequestEventType.AuthorTrustLevelChanged => "AUTHOR_TRUST_LEVEL_CHANGED",
                WebhooksPublicUpdateRequestEventType.AuthorUnblocked => "AUTHOR_UNBLOCKED",
                WebhooksPublicUpdateRequestEventType.AuthorUpdated => "AUTHOR_UPDATED",
                WebhooksPublicUpdateRequestEventType.QueueItemAction => "QUEUE_ITEM_ACTION",
                WebhooksPublicUpdateRequestEventType.QueueItemAllowed => "QUEUE_ITEM_ALLOWED",
                WebhooksPublicUpdateRequestEventType.QueueItemCompleted => "QUEUE_ITEM_COMPLETED",
                WebhooksPublicUpdateRequestEventType.QueueItemNew => "QUEUE_ITEM_NEW",
                WebhooksPublicUpdateRequestEventType.QueueItemRejected => "QUEUE_ITEM_REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPublicUpdateRequestEventType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_ACTION" => WebhooksPublicUpdateRequestEventType.AuthorAction,
                "AUTHOR_BLOCKED" => WebhooksPublicUpdateRequestEventType.AuthorBlocked,
                "AUTHOR_SUSPENDED" => WebhooksPublicUpdateRequestEventType.AuthorSuspended,
                "AUTHOR_TRUST_LEVEL_CHANGED" => WebhooksPublicUpdateRequestEventType.AuthorTrustLevelChanged,
                "AUTHOR_UNBLOCKED" => WebhooksPublicUpdateRequestEventType.AuthorUnblocked,
                "AUTHOR_UPDATED" => WebhooksPublicUpdateRequestEventType.AuthorUpdated,
                "QUEUE_ITEM_ACTION" => WebhooksPublicUpdateRequestEventType.QueueItemAction,
                "QUEUE_ITEM_ALLOWED" => WebhooksPublicUpdateRequestEventType.QueueItemAllowed,
                "QUEUE_ITEM_COMPLETED" => WebhooksPublicUpdateRequestEventType.QueueItemCompleted,
                "QUEUE_ITEM_NEW" => WebhooksPublicUpdateRequestEventType.QueueItemNew,
                "QUEUE_ITEM_REJECTED" => WebhooksPublicUpdateRequestEventType.QueueItemRejected,
                _ => null,
            };
        }
    }
}