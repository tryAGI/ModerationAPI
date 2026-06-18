#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public class GetStreamRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.GetStreamRequest>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.GetStreamRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.GetStreamRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.GetStreamRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.GetStreamRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ModerationAPI.VoiceStartFrame? start = default;
            if (discriminator?.Event == global::ModerationAPI.GetStreamRequestDiscriminatorEvent.Start)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceStartFrame), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceStartFrame> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.VoiceStartFrame)}");
                start = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.VoiceMediaFrame? media = default;
            if (discriminator?.Event == global::ModerationAPI.GetStreamRequestDiscriminatorEvent.Media)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceMediaFrame), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceMediaFrame> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.VoiceMediaFrame)}");
                media = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ModerationAPI.VoiceStopFrame? stop = default;
            if (discriminator?.Event == global::ModerationAPI.GetStreamRequestDiscriminatorEvent.Stop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceStopFrame), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceStopFrame> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ModerationAPI.VoiceStopFrame)}");
                stop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ModerationAPI.GetStreamRequest(
                discriminator?.Event,
                start,

                media,

                stop
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.GetStreamRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceStartFrame), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceStartFrame?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.VoiceStartFrame).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start!, typeInfo);
            }
            else if (value.IsMedia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceMediaFrame), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceMediaFrame?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.VoiceMediaFrame).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Media!, typeInfo);
            }
            else if (value.IsStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ModerationAPI.VoiceStopFrame), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ModerationAPI.VoiceStopFrame?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ModerationAPI.VoiceStopFrame).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stop!, typeInfo);
            }
        }
    }
}