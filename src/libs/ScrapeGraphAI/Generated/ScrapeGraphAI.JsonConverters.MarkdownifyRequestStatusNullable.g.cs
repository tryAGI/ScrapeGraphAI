#nullable enable

namespace ScrapeGraphAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class MarkdownifyRequestStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ScrapeGraphAI.MarkdownifyRequestStatus?>
    {
        /// <inheritdoc />
        public override global::ScrapeGraphAI.MarkdownifyRequestStatus? Read(
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
                        return global::ScrapeGraphAI.MarkdownifyRequestStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ScrapeGraphAI.MarkdownifyRequestStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ScrapeGraphAI.MarkdownifyRequestStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ScrapeGraphAI.MarkdownifyRequestStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ScrapeGraphAI.MarkdownifyRequestStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
