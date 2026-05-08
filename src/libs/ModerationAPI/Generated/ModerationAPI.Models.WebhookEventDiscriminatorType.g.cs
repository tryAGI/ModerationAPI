
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookEventDiscriminatorType
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
        QueueItemRejected,
        /// <summary>
        /// 
        /// </summary>
        QueueItemResolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEventDiscriminatorType value)
        {
            return value switch
            {
                WebhookEventDiscriminatorType.AuthorAction => "author.action",
                WebhookEventDiscriminatorType.AuthorBlocked => "author.blocked",
                WebhookEventDiscriminatorType.AuthorSuspended => "author.suspended",
                WebhookEventDiscriminatorType.AuthorTrustLevelChanged => "author.trust_level_changed",
                WebhookEventDiscriminatorType.AuthorUnblocked => "author.unblocked",
                WebhookEventDiscriminatorType.AuthorUpdated => "author.updated",
                WebhookEventDiscriminatorType.QueueItemAction => "queue_item.action",
                WebhookEventDiscriminatorType.QueueItemAllowed => "queue_item.allowed",
                WebhookEventDiscriminatorType.QueueItemRejected => "queue_item.rejected",
                WebhookEventDiscriminatorType.QueueItemResolved => "queue_item.resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "author.action" => WebhookEventDiscriminatorType.AuthorAction,
                "author.blocked" => WebhookEventDiscriminatorType.AuthorBlocked,
                "author.suspended" => WebhookEventDiscriminatorType.AuthorSuspended,
                "author.trust_level_changed" => WebhookEventDiscriminatorType.AuthorTrustLevelChanged,
                "author.unblocked" => WebhookEventDiscriminatorType.AuthorUnblocked,
                "author.updated" => WebhookEventDiscriminatorType.AuthorUpdated,
                "queue_item.action" => WebhookEventDiscriminatorType.QueueItemAction,
                "queue_item.allowed" => WebhookEventDiscriminatorType.QueueItemAllowed,
                "queue_item.rejected" => WebhookEventDiscriminatorType.QueueItemRejected,
                "queue_item.resolved" => WebhookEventDiscriminatorType.QueueItemResolved,
                _ => null,
            };
        }
    }
}