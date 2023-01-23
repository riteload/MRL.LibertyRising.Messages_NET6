using System.ComponentModel.DataAnnotations;


namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentLoadMessage
    {
        public string Identifier { get; set; }
        public string Description { get; set; }
        public string Dimensions { get; set; }
        public int? Weight { get; set; }

        [Display(Name = "Unit of Measure")]
        public int? UnitOfMeasureId { get; set; }
        public string UnitOfMeasure { get; set; }

        [Display(Name = "Invoice Number")]
        public string InvoiceNumber { get; set; }

        [Display(Name = "Pallet Count")]
        public int? PalletCount { get; set; }

        [Display(Name = "Crate Count")]
        public int? CrateCount { get; set; }

        [Display(Name = "Is Oversized Load")]
        public int? IsOversizedLoad { get; set; }

        [Display(Name = "Vehicle Trailor Type")]
        public int? VehicleTrailorTypeId { get; set; }
        public string VehicleTrailorType { get; set; }

        [Display(Name = "Truck Load Type")]
        public int? TruckLoadTypeId { get; set; }
        public string TruckLoadType { get; set; }

        [Display(Name = "TWIC Card Required")]
        public int? RequiresTwicCard { get; set; }

        //[Display(Name = "Status")]
        //public int StatusId { get; set; }
    }
}
