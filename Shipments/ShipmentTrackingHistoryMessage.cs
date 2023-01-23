using System;
using System.Collections.Generic;
using MRL.LibertyRising.Messages.Tracking;

namespace MRL.LibertyRising.Messages.Shipments
{
    [Obsolete]
    public class ShipmentTrackingHistoryMessage
    {
        public IEnumerable<CoordinateMessage> Coordinates { get; set; }
        public long Index { get; set; }
        public int Count { get; set; }
        public int ShipmentStatusId { get; set; }
        public string ShipmentStatus { get; set; }

        public ShipmentTrackingHistoryMessage()
        {
            Coordinates = new List<CoordinateMessage>();
        }
    }
}
