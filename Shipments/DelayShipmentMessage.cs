namespace MRL.LibertyRising.Messages.Shipments
{
    public class DelayShipmentMessage
    {
        public string ShipmentIdentifier { get; set; }
        public string Reason { get; set; }
    }
}
