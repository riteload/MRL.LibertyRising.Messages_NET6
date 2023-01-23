using System;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Converters
{
    public class TimeSpanJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.ValueType == typeof(TimeSpan))
            {
                return ((TimeSpan)reader.Value);
            }

            var value = (string)reader.Value;

            TimeSpan result;
            if (!TimeSpan.TryParse(value, out result))
            {
                return null;
            }
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var timeSpan = value as TimeSpan?;
            if (timeSpan == null) return;
            var time = timeSpan.Value;

            writer.WriteValue(time.ToString(@"hh\:mm\:ss"));

        }
    }
}
