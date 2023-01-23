namespace MRL.LibertyRising.Messages.Shipments
{
    public class DeliverShipmentMessage
    {
        public string ShipmentIdentifier { get; set; }
        public string ReceiverSignature { get; set; }
        public string ReceiverName { get; set; }
        public int[] DeliveryDamageTypeIds { get; set; }
        public string BillOfLadingHandle { get; set; }

        public string ScaleTicketsHandle { get; set; }

        public int? NetWeight { get; set; }
    }
}
