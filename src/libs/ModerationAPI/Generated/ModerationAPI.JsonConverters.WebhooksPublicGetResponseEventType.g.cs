#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksPublicGetResponseEventTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.WebhooksPublicGetResponseEventType>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.WebhooksPublicGetResponseEventType Read(
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
                        return global::ModerationAPI.WebhooksPublicGetResponseEventTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.WebhooksPublicGetResponseEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.WebhooksPublicGetResponseEventType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.WebhooksPublicGetResponseEventType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ModerationAPI.WebhooksPublicGetResponseEventTypeExtensions.ToValueString(value));
        }
    }
}
