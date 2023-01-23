
namespace MRL.LibertyRising.Messages.Shipments
{
    public class RequestedShipmentMessage
    {
        public ShipmentMessage Shipment { get; set; }
        public int RequestCount { get; set; }
    }
}
