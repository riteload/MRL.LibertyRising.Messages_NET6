namespace MRL.LibertyRising.Messages.Shipments
{
    public class ChangeShipmentStatusResultMessage
    {
        public ShipmentMessage Shipment { get; set; }
        public bool Successful { get; set; }
        public int? FailureReasonId { get; set; } 
        public string FailureReason { get; set; }
    }
}
