using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentSummaryMessage
    {
        public string OriginAddress { get; set; }

        public string OriginCity { get; set; }

        public string OriginStateName { get; set; }

        public string OriginStateAbbreviation { get; set; }

        public string OriginPostalCode { get; set; }

        public string DestinationAddress { get; set; }

        public string DestinationCity { get; set; }

        public string DestinationStateName { get; set; }

        public string DestinationStateAbbreviation { get; set; }

        public string DestinationPostalCode { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? PickUpDateTime { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? PickUpDateTimeLocal { get; set; }

        public string PickUpDateTimeZone { get; set; }

        public string PickUpDateTimeZoneShortName { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDateTime { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDateTimeLocal { get; set; }

        public string DropOffDateTimeZone { get; set; }

        public string DropOffDateTimeZoneShortName { get; set; }

        public string InvoiceNumber { get; set; }

        public string TruckLoadType { get; set; }

        public int? Weight { get; set; }

        public bool? RequiresTwicCard { get; set; }

        public decimal? ShipmentPaymentRate { get; set; }

        public string ShipmentPaymentType { get; set; }

        public string UnitOfMeasure { get; set; }
    }
}
