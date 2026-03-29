#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType?>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType? Read(
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
                        return global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
