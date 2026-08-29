#nullable enable

namespace ScrapeGraphAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgenticScrapperStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ScrapeGraphAI.AgenticScrapperStatus?>
    {
        /// <inheritdoc />
        public override global::ScrapeGraphAI.AgenticScrapperStatus? Read(
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
                        return global::ScrapeGraphAI.AgenticScrapperStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ScrapeGraphAI.AgenticScrapperStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ScrapeGraphAI.AgenticScrapperStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ScrapeGraphAI.AgenticScrapperStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ScrapeGraphAI.AgenticScrapperStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
