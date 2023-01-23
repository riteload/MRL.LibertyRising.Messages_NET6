using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Tracking
{
    public class CoordinateMessage
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double? Altitude { get; set; }
        public float? Speed { get; set; }
        public float? Accuracy { get; set; }
        public float? Bearing { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime Date { get; set; }

        public CoordinateMessage(string latitude, string longitude)
        {
            Latitude = Convert.ToDouble(latitude);
            Longitude = Convert.ToDouble(longitude);
        }

        public CoordinateMessage(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public CoordinateMessage()
        {
            
        }
    }
}
