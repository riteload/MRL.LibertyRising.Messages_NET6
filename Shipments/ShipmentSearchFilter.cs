using System;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentSearchFilter
    {
        public int[] OriginStateIds { get; set; }
        public string OriginPostalCode { get; set; }
        public int[] DestinationStateIds { get; set; }
        public string DestinationPostalCode { get; set; }
        public int[] TrailerTypeIds { get; set; }
        [Obsolete]
        public int[] PaymentTypes { get; set; } //TODO: rename to PaymentTypeIds
        [Obsolete]
        public int[] LoadTypeIds { get; set; }
        public DateTime? PickUpDate { get; set; }
        public DateTime? DropOffDate { get; set; }
        public bool? TwicRequired { get; set; }
        public int[] RequestStatusIds { get; set; } //TODO This may be redundant
        public int[] StatusIds { get; set; }
        public string Identifier { get; set; }

        public ShipmentSearchFilter()
        {
            OriginStateIds = new int[] { };
            DestinationStateIds = new int[] { };
            TrailerTypeIds = new int[] { };
            PaymentTypes = new int[] { };
            LoadTypeIds = new int[] { };
            RequestStatusIds = new int[] { };
            StatusIds = new int[] { };
        }
    }
}
