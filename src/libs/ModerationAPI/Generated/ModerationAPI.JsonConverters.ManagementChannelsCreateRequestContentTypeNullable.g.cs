#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManagementChannelsCreateRequestContentTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.ManagementChannelsCreateRequestContentType?>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.ManagementChannelsCreateRequestContentType? Read(
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
                        return global::ModerationAPI.ManagementChannelsCreateRequestContentTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.ManagementChannelsCreateRequestContentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.ManagementChannelsCreateRequestContentType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.ManagementChannelsCreateRequestContentType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ModerationAPI.ManagementChannelsCreateRequestContentTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
