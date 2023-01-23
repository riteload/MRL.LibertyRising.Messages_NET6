
namespace MRL.LibertyRising.Messages.Shipments
{
    public class RejectShipmentMessage
    {
        public string ShipmentIdentifier { get; set; }
        public string Reason { get; set; }
    }
}
