#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class NewModerateModerateResponseCasebookVerdictJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.NewModerateModerateResponseCasebookVerdict>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.NewModerateModerateResponseCasebookVerdict Read(
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
                        return global::ModerationAPI.NewModerateModerateResponseCasebookVerdictExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.NewModerateModerateResponseCasebookVerdict)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.NewModerateModerateResponseCasebookVerdict);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.NewModerateModerateResponseCasebookVerdict value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ModerationAPI.NewModerateModerateResponseCasebookVerdictExtensions.ToValueString(value));
        }
    }
}
