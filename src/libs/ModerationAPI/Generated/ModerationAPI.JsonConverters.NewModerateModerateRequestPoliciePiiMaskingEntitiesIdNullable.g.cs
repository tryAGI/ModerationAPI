#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class NewModerateModerateRequestPoliciePiiMaskingEntitiesIdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntitiesId?>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntitiesId? Read(
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
                        return global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntitiesIdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntitiesId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntitiesId?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntitiesId? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntitiesIdExtensions.ToValueString(value.Value));
            }
        }
    }
}
