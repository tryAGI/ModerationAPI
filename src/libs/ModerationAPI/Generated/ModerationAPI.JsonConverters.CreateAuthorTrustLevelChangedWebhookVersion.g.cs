#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAuthorTrustLevelChangedWebhookVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersion>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersion Read(
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
                        return global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ModerationAPI.CreateAuthorTrustLevelChangedWebhookVersionExtensions.ToValueString(value));
        }
    }
}
