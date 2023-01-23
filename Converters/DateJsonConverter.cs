using System;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Converters
{
    public class DateJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.ValueType == typeof(DateTime))
            {
                return ((DateTime)reader.Value).Date;
            }

            var value = (string)reader.Value;

            DateTime result;
            if (!DateTime.TryParse(value, out result))
            {
                return null;
            }
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var dateTime = value as DateTime?;
            if (dateTime == null) return;
            var date = dateTime.Value;

            writer.WriteValue(date.ToString("yyyy-MM-dd"));
        }
    }
}
