#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public class WebhookEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.WebhookEvent>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.WebhookEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.WebhookEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.WebhookEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.WebhookEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ModerationAPI.AuthorBlockedEvent? authorBlocked = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.AuthorBlocked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorBlockedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorBlockedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.AuthorBlockedEvent)}");
                authorBlocked = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.AuthorUnblockedEvent? authorUnblocked = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.AuthorUnblocked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorUnblockedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorUnblockedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.AuthorUnblockedEvent)}");
                authorUnblocked = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.AuthorSuspendedEvent? authorSuspended = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.AuthorSuspended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorSuspendedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorSuspendedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.AuthorSuspendedEvent)}");
                authorSuspended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.AuthorUpdatedEvent? authorUpdated = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.AuthorUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorUpdatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.AuthorUpdatedEvent)}");
                authorUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.AuthorTrustLevelChangedEvent? authorTrustLevelChanged = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.AuthorTrustLevelChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorTrustLevelChangedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorTrustLevelChangedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.AuthorTrustLevelChangedEvent)}");
                authorTrustLevelChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.AuthorActionEvent? authorAction = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.AuthorAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorActionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorActionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.AuthorActionEvent)}");
                authorAction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.QueueItemCompletedEvent? queueItemResolved = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.QueueItemResolved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.QueueItemCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.QueueItemCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.QueueItemCompletedEvent)}");
                queueItemResolved = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.QueueItemActionEvent? queueItemAction = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.QueueItemAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.QueueItemActionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.QueueItemActionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.QueueItemActionEvent)}");
                queueItemAction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.QueueItemRejectedEvent? queueItemRejected = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.QueueItemRejected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.QueueItemRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.QueueItemRejectedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.QueueItemRejectedEvent)}");
                queueItemRejected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.QueueItemAllowedEvent? queueItemAllowed = default;
            if (discriminator?.Type == global::ModerationAPI.WebhookEventDiscriminatorType.QueueItemAllowed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.QueueItemAllowedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.QueueItemAllowedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.QueueItemAllowedEvent)}");
                queueItemAllowed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ModerationAPI.WebhookEvent(
                discriminator?.Type,
                authorBlocked,

                authorUnblocked,

                authorSuspended,

                authorUpdated,

                authorTrustLevelChanged,

                authorAction,

                queueItemResolved,

                queueItemAction,

                queueItemRejected,

                queueItemAllowed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.WebhookEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAuthorBlocked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorBlockedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorBlockedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.AuthorBlockedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthorBlocked!, typeInfo);
            }
            else if (value.IsAuthorUnblocked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorUnblockedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorUnblockedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.AuthorUnblockedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthorUnblocked!, typeInfo);
            }
            else if (value.IsAuthorSuspended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorSuspendedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorSuspendedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.AuthorSuspendedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthorSuspended!, typeInfo);
            }
            else if (value.IsAuthorUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorUpdatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorUpdatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.AuthorUpdatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthorUpdated!, typeInfo);
            }
            else if (value.IsAuthorTrustLevelChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorTrustLevelChangedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorTrustLevelChangedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.AuthorTrustLevelChangedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthorTrustLevelChanged!, typeInfo);
            }
            else if (value.IsAuthorAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.AuthorActionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.AuthorActionEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.AuthorActionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AuthorAction!, typeInfo);
            }
            else if (value.IsQueueItemResolved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.QueueItemCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.QueueItemCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.QueueItemCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueueItemResolved!, typeInfo);
            }
            else if (value.IsQueueItemAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.QueueItemActionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.QueueItemActionEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.QueueItemActionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueueItemAction!, typeInfo);
            }
            else if (value.IsQueueItemRejected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.QueueItemRejectedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.QueueItemRejectedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.QueueItemRejectedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueueItemRejected!, typeInfo);
            }
            else if (value.IsQueueItemAllowed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.QueueItemAllowedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.QueueItemAllowedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.QueueItemAllowedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueueItemAllowed!, typeInfo);
            }
        }
    }
}