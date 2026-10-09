#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class QueueViewOpenGetQueueResponseQueueFilterWithinUnitJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnit>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnit Read(
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
                        return global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnitExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnit)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnit);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnit value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterWithinUnitExtensions.ToValueString(value));
        }
    }
}
