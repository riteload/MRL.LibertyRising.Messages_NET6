namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentLocationStatusMessage
    {
        public int StatusId { get; set; }
        public string Status { get; set; }
        public bool ShouldStopUpdating { get; set; }
    }
}
