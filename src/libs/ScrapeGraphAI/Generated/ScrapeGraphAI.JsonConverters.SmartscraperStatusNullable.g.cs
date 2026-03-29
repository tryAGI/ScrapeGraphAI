#nullable enable

namespace ScrapeGraphAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class SmartscraperStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ScrapeGraphAI.SmartscraperStatus?>
    {
        /// <inheritdoc />
        public override global::ScrapeGraphAI.SmartscraperStatus? Read(
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
                        return global::ScrapeGraphAI.SmartscraperStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ScrapeGraphAI.SmartscraperStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ScrapeGraphAI.SmartscraperStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ScrapeGraphAI.SmartscraperStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ScrapeGraphAI.SmartscraperStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
