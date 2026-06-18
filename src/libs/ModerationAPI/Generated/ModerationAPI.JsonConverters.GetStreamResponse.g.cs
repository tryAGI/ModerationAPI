#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public class GetStreamResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.GetStreamResponse>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.GetStreamResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.GetStreamResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.GetStreamResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.GetStreamResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ModerationAPI.VoiceSessionStarted? sessionStarted = default;
            if (discriminator?.Event == global::ModerationAPI.GetStreamResponseDiscriminatorEvent.SessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceSessionStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceSessionStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.VoiceSessionStarted)}");
                sessionStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.VoiceUtteranceFinal? utteranceFinal = default;
            if (discriminator?.Event == global::ModerationAPI.GetStreamResponseDiscriminatorEvent.UtteranceFinal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceUtteranceFinal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceUtteranceFinal> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.VoiceUtteranceFinal)}");
                utteranceFinal = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.VoiceSessionEnded? sessionEnded = default;
            if (discriminator?.Event == global::ModerationAPI.GetStreamResponseDiscriminatorEvent.SessionEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceSessionEnded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceSessionEnded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.VoiceSessionEnded)}");
                sessionEnded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ModerationAPI.GetStreamResponse(
                discriminator?.Event,
                sessionStarted,

                utteranceFinal,

                sessionEnded
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.GetStreamResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceSessionStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceSessionStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.VoiceSessionStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStarted!, typeInfo);
            }
            else if (value.IsUtteranceFinal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceUtteranceFinal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceUtteranceFinal?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.VoiceUtteranceFinal).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UtteranceFinal!, typeInfo);
            }
            else if (value.IsSessionEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceSessionEnded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceSessionEnded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.VoiceSessionEnded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionEnded!, typeInfo);
            }
        }
    }
}