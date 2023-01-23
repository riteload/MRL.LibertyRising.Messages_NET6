namespace MRL.LibertyRising.Messages.Shipments
{
    public class CancelShipmentMessage
    {
        public string ShipmentIdentifier { get; set; }
        public string Reason { get; set; }
    }
}
