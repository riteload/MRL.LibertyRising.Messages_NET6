using System;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Converters
{
    public class DateTimeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = DateTime.MinValue;

            if (reader.ValueType == typeof(DateTime))
            {
                value = (DateTime)reader.Value;
            }

            if (reader.ValueType == typeof(string))
            {
                if (!DateTime.TryParse(reader.Value.ToString(), out value))
                {
                    return DateTime.MinValue;
                }
            }

            var date = new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second, value.Millisecond, DateTimeKind.Utc);

            return date;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dateTime = value as DateTime?;
            if (dateTime == null) return;
            var date = dateTime.Value;

            writer.WriteValue(date.ToString("s") + "Z");
        }
    }
}
