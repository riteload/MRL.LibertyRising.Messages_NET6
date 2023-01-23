using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Shipments
{
    [Obsolete("UseShipmentTrackingStatus2Message")]
    public class ShipmentTrackingStatusMessage
    {
        public int ShipmentStatusId { get; set; }
        public string ShipmentStatus { get; set; }
        public string ShipmentIdentifier { get; set; }
        public bool StopTracking { get; set; }
        public string Message { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime Date { get; set; }
    }
}
