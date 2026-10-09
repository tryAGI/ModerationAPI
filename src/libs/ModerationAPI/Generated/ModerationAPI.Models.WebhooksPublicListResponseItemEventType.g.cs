
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksPublicListResponseItemEventType
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
    public static class WebhooksPublicListResponseItemEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPublicListResponseItemEventType value)
        {
            return value switch
            {
                WebhooksPublicListResponseItemEventType.AuthorAction => "AUTHOR_ACTION",
                WebhooksPublicListResponseItemEventType.AuthorBlocked => "AUTHOR_BLOCKED",
                WebhooksPublicListResponseItemEventType.AuthorSuspended => "AUTHOR_SUSPENDED",
                WebhooksPublicListResponseItemEventType.AuthorTrustLevelChanged => "AUTHOR_TRUST_LEVEL_CHANGED",
                WebhooksPublicListResponseItemEventType.AuthorUnblocked => "AUTHOR_UNBLOCKED",
                WebhooksPublicListResponseItemEventType.AuthorUpdated => "AUTHOR_UPDATED",
                WebhooksPublicListResponseItemEventType.QueueItemAction => "QUEUE_ITEM_ACTION",
                WebhooksPublicListResponseItemEventType.QueueItemAllowed => "QUEUE_ITEM_ALLOWED",
                WebhooksPublicListResponseItemEventType.QueueItemCompleted => "QUEUE_ITEM_COMPLETED",
                WebhooksPublicListResponseItemEventType.QueueItemNew => "QUEUE_ITEM_NEW",
                WebhooksPublicListResponseItemEventType.QueueItemRejected => "QUEUE_ITEM_REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPublicListResponseItemEventType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_ACTION" => WebhooksPublicListResponseItemEventType.AuthorAction,
                "AUTHOR_BLOCKED" => WebhooksPublicListResponseItemEventType.AuthorBlocked,
                "AUTHOR_SUSPENDED" => WebhooksPublicListResponseItemEventType.AuthorSuspended,
                "AUTHOR_TRUST_LEVEL_CHANGED" => WebhooksPublicListResponseItemEventType.AuthorTrustLevelChanged,
                "AUTHOR_UNBLOCKED" => WebhooksPublicListResponseItemEventType.AuthorUnblocked,
                "AUTHOR_UPDATED" => WebhooksPublicListResponseItemEventType.AuthorUpdated,
                "QUEUE_ITEM_ACTION" => WebhooksPublicListResponseItemEventType.QueueItemAction,
                "QUEUE_ITEM_ALLOWED" => WebhooksPublicListResponseItemEventType.QueueItemAllowed,
                "QUEUE_ITEM_COMPLETED" => WebhooksPublicListResponseItemEventType.QueueItemCompleted,
                "QUEUE_ITEM_NEW" => WebhooksPublicListResponseItemEventType.QueueItemNew,
                "QUEUE_ITEM_REJECTED" => WebhooksPublicListResponseItemEventType.QueueItemRejected,
                _ => null,
            };
        }
    }
}