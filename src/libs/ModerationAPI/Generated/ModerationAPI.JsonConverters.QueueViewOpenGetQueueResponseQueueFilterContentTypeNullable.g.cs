#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class QueueViewOpenGetQueueResponseQueueFilterContentTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType?>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType? Read(
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
                        return global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterContentTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
