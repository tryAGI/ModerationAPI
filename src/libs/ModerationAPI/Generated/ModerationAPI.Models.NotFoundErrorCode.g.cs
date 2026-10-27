
#nullable enable

namespace ModerationAPI
{

    /// <summary>
    /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
    /// - `resource_not_found`: The resource does not exist.<br/>
    /// - `action_not_found`: The action does not exist.<br/>
    /// - `author_not_found`: The author does not exist.<br/>
    /// - `queue_not_found`: The review queue does not exist.<br/>
    /// - `queue_item_not_found`: The queue item does not exist in the project.<br/>
    /// - `wordlist_not_found`: The wordlist does not exist.<br/>
    /// - `webhook_not_found`: The webhook does not exist.<br/>
    /// - `project_not_found`: The project does not exist.<br/>
    /// - `channel_not_found`: The channel does not exist.<br/>
    /// Example: resource_not_found
    /// </summary>
    public readonly partial struct NotFoundErrorCode : global::System.IEquatable<NotFoundErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public NotFoundErrorCode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// The action does not exist.
        /// </summary>
        public static NotFoundErrorCode ActionNotFound { get; } = new("action_not_found");

        /// <summary>
        /// The author does not exist.
        /// </summary>
        public static NotFoundErrorCode AuthorNotFound { get; } = new("author_not_found");

        /// <summary>
        /// The channel does not exist.
        /// </summary>
        public static NotFoundErrorCode ChannelNotFound { get; } = new("channel_not_found");

        /// <summary>
        /// The project does not exist.
        /// </summary>
        public static NotFoundErrorCode ProjectNotFound { get; } = new("project_not_found");

        /// <summary>
        /// The queue item does not exist in the project.
        /// </summary>
        public static NotFoundErrorCode QueueItemNotFound { get; } = new("queue_item_not_found");

        /// <summary>
        /// The review queue does not exist.
        /// </summary>
        public static NotFoundErrorCode QueueNotFound { get; } = new("queue_not_found");

        /// <summary>
        /// The resource does not exist.
        /// </summary>
        public static NotFoundErrorCode ResourceNotFound { get; } = new("resource_not_found");

        /// <summary>
        /// The webhook does not exist.
        /// </summary>
        public static NotFoundErrorCode WebhookNotFound { get; } = new("webhook_not_found");

        /// <summary>
        /// The wordlist does not exist.
        /// </summary>
        public static NotFoundErrorCode WordlistNotFound { get; } = new("wordlist_not_found");
        /// <summary>
        ///
        /// </summary>
        public static NotFoundErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "action_not_found" => ActionNotFound,
                "author_not_found" => AuthorNotFound,
                "channel_not_found" => ChannelNotFound,
                "project_not_found" => ProjectNotFound,
                "queue_item_not_found" => QueueItemNotFound,
                "queue_not_found" => QueueNotFound,
                "resource_not_found" => ResourceNotFound,
                "webhook_not_found" => WebhookNotFound,
                "wordlist_not_found" => WordlistNotFound,
                _ => new NotFoundErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "action_not_found" => true,
            "author_not_found" => true,
            "channel_not_found" => true,
            "project_not_found" => true,
            "queue_item_not_found" => true,
            "queue_not_found" => true,
            "resource_not_found" => true,
            "webhook_not_found" => true,
            "wordlist_not_found" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(NotFoundErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NotFoundErrorCode other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NotFoundErrorCode left, NotFoundErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NotFoundErrorCode left, NotFoundErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotFoundErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotFoundErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotFoundErrorCode? ToEnum(string value)
        {
            return NotFoundErrorCode.FromValue(value);
        }
    }
}