#nullable enable

namespace ScrapeGraphAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class MarkdownifyStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ScrapeGraphAI.MarkdownifyStatus>
    {
        /// <inheritdoc />
        public override global::ScrapeGraphAI.MarkdownifyStatus Read(
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
                        return global::ScrapeGraphAI.MarkdownifyStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ScrapeGraphAI.MarkdownifyStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ScrapeGraphAI.MarkdownifyStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ScrapeGraphAI.MarkdownifyStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ScrapeGraphAI.MarkdownifyStatusExtensions.ToValueString(value));
        }
    }
}
