
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhooksPublicListResponseDataItemEventType
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
    public static class WebhooksPublicListResponseDataItemEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPublicListResponseDataItemEventType value)
        {
            return value switch
            {
                WebhooksPublicListResponseDataItemEventType.AuthorAction => "AUTHOR_ACTION",
                WebhooksPublicListResponseDataItemEventType.AuthorBlocked => "AUTHOR_BLOCKED",
                WebhooksPublicListResponseDataItemEventType.AuthorSuspended => "AUTHOR_SUSPENDED",
                WebhooksPublicListResponseDataItemEventType.AuthorTrustLevelChanged => "AUTHOR_TRUST_LEVEL_CHANGED",
                WebhooksPublicListResponseDataItemEventType.AuthorUnblocked => "AUTHOR_UNBLOCKED",
                WebhooksPublicListResponseDataItemEventType.AuthorUpdated => "AUTHOR_UPDATED",
                WebhooksPublicListResponseDataItemEventType.QueueItemAction => "QUEUE_ITEM_ACTION",
                WebhooksPublicListResponseDataItemEventType.QueueItemAllowed => "QUEUE_ITEM_ALLOWED",
                WebhooksPublicListResponseDataItemEventType.QueueItemCompleted => "QUEUE_ITEM_COMPLETED",
                WebhooksPublicListResponseDataItemEventType.QueueItemNew => "QUEUE_ITEM_NEW",
                WebhooksPublicListResponseDataItemEventType.QueueItemRejected => "QUEUE_ITEM_REJECTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPublicListResponseDataItemEventType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_ACTION" => WebhooksPublicListResponseDataItemEventType.AuthorAction,
                "AUTHOR_BLOCKED" => WebhooksPublicListResponseDataItemEventType.AuthorBlocked,
                "AUTHOR_SUSPENDED" => WebhooksPublicListResponseDataItemEventType.AuthorSuspended,
                "AUTHOR_TRUST_LEVEL_CHANGED" => WebhooksPublicListResponseDataItemEventType.AuthorTrustLevelChanged,
                "AUTHOR_UNBLOCKED" => WebhooksPublicListResponseDataItemEventType.AuthorUnblocked,
                "AUTHOR_UPDATED" => WebhooksPublicListResponseDataItemEventType.AuthorUpdated,
                "QUEUE_ITEM_ACTION" => WebhooksPublicListResponseDataItemEventType.QueueItemAction,
                "QUEUE_ITEM_ALLOWED" => WebhooksPublicListResponseDataItemEventType.QueueItemAllowed,
                "QUEUE_ITEM_COMPLETED" => WebhooksPublicListResponseDataItemEventType.QueueItemCompleted,
                "QUEUE_ITEM_NEW" => WebhooksPublicListResponseDataItemEventType.QueueItemNew,
                "QUEUE_ITEM_REJECTED" => WebhooksPublicListResponseDataItemEventType.QueueItemRejected,
                _ => null,
            };
        }
    }
}