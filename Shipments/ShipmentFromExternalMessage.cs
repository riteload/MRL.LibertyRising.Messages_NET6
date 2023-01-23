using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;
using System;
using MRL.LibertyRising.Messages.Accounts;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentFromExternalMessage
    {
        public string ShipmentIdentifier { get; set; }

        public string ShipperUserIdentifier { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? PickUpDateTimeLocal { get; set; }
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDateTimeLocal { get; set; }



        //Pick Up Data
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? PickUpDate { get; set; }
        [JsonConverter(typeof(TimeSpanJsonConverter))]
        public TimeSpan? PickUpTime { get; set; }
        public string PickUpDateTimeZone { get; set; }
        public int? PickUpDateTimeZoneId { get; set; }


        //Drop Off Data
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDate { get; set; }    
        [JsonConverter(typeof(TimeSpanJsonConverter))]
        public TimeSpan? DropOffTime { get; set; }
        public string DropOffDateTimeZone { get; set; }
        public int? DropOffDateTimeZoneId { get; set; }

        //Load Data
        public string Description { get; set; }
        public string Dimensions { get; set; }
        public int? Weight { get; set; }
        public string UnitOfMeasure { get; set; }
        public string InvoiceNumber { get; set; } 
        public int? PalletCount { get; set; }
        public int? CrateCount { get; set; }
        public int? IsOversizedLoad { get; set; } 
        public string VehicleTrailorType { get; set; }
        public string TruckLoadType { get; set; }
        public int? RequiresTwicCard { get; set; }

        //Payment Data
        public decimal? ShipmentPaymentRate { get; set; }
        public int? Distance { get; set; }
        public string ShipmentPaymentType { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public int? FuelSurchargeIncluded{ get; set; }

        //pick up and drop off locations
        public WarehouseMessage Origin { get; set; }
        public WarehouseMessage Destination{ get; set; }

        //new shipper to be added for load if necessary
        public AccountFromExternalMessage NewShipper { get; set; }
    }
}
