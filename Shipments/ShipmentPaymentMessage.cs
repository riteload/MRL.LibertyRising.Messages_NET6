using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentPaymentMessage 
    {
        public string Identifier { get; set; }

        [Display(Name = "Contract")]
        public string ContractIdentifier { get; set; }

        [Display(Name = "Shipment Payment Rate")]
        public decimal? ShipmentPaymentRate { get; set; }

        [Display(Name = "Distance")]
        public int? Distance { get; set; }

        [Display(Name = "Shipment Weight")]
        public decimal? ShipmentWeight { get; set; }

        [Display(Name = "Shipment Payment Type")]
        public string ShipmentPaymentType { get; set; }

        [Display(Name = "Shipment Payment Type Id")]
        public int? ShipmentPaymentTypeId { get; set; }

        [Display(Name = "Fuel Surcharge")]
        public decimal? FuelSurcharge { get; set; }

        [Display(Name = "Fuel Surcharge Included")]
        public bool FuelSurchargeIncluded { get; set; }

        [Display(Name = "Est. Total")]
        public decimal? EstTotal { get; set; }

        public bool QuickPayEligible { get; set; }

        //[Display(Name = "Status")]
        //public int StatusId { get; set; }
    }
}
