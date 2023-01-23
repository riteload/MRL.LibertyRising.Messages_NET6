namespace MRL.LibertyRising.Messages.Shipments
{
    public class DispatcherShipmentRequestMessage
    {
        public string ShipmentIdentifier { get; set; }
        public decimal? CounterAmount { get; set; }
        public decimal? CounterEstTotal { get; set; }
        public bool QuickPayRequested { get; set; }
    }
}
