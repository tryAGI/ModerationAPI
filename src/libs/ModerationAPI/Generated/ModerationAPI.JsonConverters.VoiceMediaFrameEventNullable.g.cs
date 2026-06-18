#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class VoiceMediaFrameEventNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.VoiceMediaFrameEvent?>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.VoiceMediaFrameEvent? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::ModerationAPI.VoiceMediaFrameEventExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.VoiceMediaFrameEvent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.VoiceMediaFrameEvent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.VoiceMediaFrameEvent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ModerationAPI.VoiceMediaFrameEventExtensions.ToValueString(value.Value));
            }
        }
    }
}
