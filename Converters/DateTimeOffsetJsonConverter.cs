using System;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Converters
{
    public class DateTimeOffsetJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTimeOffset);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = DateTimeOffset.MinValue;

            if (reader.ValueType == typeof(DateTimeOffset))
            {
                value = (DateTimeOffset)reader.Value;
            }

            if (reader.ValueType == typeof(DateTime))
            {
                value = new DateTimeOffset((DateTime)reader.Value);
            }

            if (reader.ValueType == typeof(string))
            {
                if (!DateTimeOffset.TryParse(reader.Value.ToString(), out value))
                {
                    return DateTimeOffset.MinValue; 
                }
            }

            var date = new DateTimeOffset(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0, 0, value.Offset); //remove seconds

            return date;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dateTime = value as DateTimeOffset?;
            if (dateTime == null) return;
            var date = dateTime.Value;

            writer.WriteValue(date.ToString("s") + "Z");
        }
    }
}
