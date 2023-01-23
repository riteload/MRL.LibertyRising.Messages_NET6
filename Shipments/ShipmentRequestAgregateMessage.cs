using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentRequestAgregateMessage
    {
        public ShipmentMessage Shipment { get; set; }
        public int TotalRequests { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime AsOfDate { get; set; }
    }
}
