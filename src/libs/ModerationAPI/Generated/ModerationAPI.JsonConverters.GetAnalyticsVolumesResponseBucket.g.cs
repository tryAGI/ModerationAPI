#nullable enable

namespace ModerationAPI.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAnalyticsVolumesResponseBucketJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ModerationAPI.GetAnalyticsVolumesResponseBucket>
    {
        /// <inheritdoc />
        public override global::ModerationAPI.GetAnalyticsVolumesResponseBucket Read(
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
                        return global::ModerationAPI.GetAnalyticsVolumesResponseBucketExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ModerationAPI.GetAnalyticsVolumesResponseBucket)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ModerationAPI.GetAnalyticsVolumesResponseBucket);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ModerationAPI.GetAnalyticsVolumesResponseBucket value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ModerationAPI.GetAnalyticsVolumesResponseBucketExtensions.ToValueString(value));
        }
    }
}
