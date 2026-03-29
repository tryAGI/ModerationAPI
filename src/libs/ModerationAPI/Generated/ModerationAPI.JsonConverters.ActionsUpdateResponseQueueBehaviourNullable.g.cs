#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActionsUpdateResponseQueueBehaviourNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.ActionsUpdateResponseQueueBehaviour?>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.ActionsUpdateResponseQueueBehaviour? Read(
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
                        return global::ModerationAPI.ActionsUpdateResponseQueueBehaviourExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.ActionsUpdateResponseQueueBehaviour)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.ActionsUpdateResponseQueueBehaviour? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ModerationAPI.ActionsUpdateResponseQueueBehaviourExtensions.ToValueString(value.Value));
            }
        }
    }
}
