using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using MRL.LibertyRising.Messages.Invoices;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentMessage
    {
        public string Identifier { get; set; }
        public string CompanyIdentifier { get; set; }
        public CompanyMessage Company { get; set; }
        public ShipmentLocationMessage Origin { get; set; }
        public ShipmentLocationMessage Destination { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime PickUpDate { get; set; }

        [JsonConverter(typeof(TimeSpanJsonConverter))]
        public TimeSpan? PickUpTime { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime PickUpDateLocal { get; set; }

        [JsonConverter(typeof(TimeSpanJsonConverter))]
        public TimeSpan? PickUpTimeLocal { get; set; }

        [Obsolete]//I don't think we need this... but let's keep for legacy for now
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime PickUpDateTime { get; set; }

        [Obsolete]//I don't think we need this... but let's keep for legacy for now
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime PickUpDateTimeLocal { get; set; }

        public string PickUpDateTimeZone { get; set; }
        public string PickUpDateTimeZoneShortName { get; set; }
        public int? PickUpDateTimeZoneId { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDate { get; set; }

        [JsonConverter(typeof(TimeSpanJsonConverter))]
        public TimeSpan? DropOffTime { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDateLocal { get; set; }

        [JsonConverter(typeof(TimeSpanJsonConverter))]
        public TimeSpan? DropOffTimeLocal { get; set; }

        [Obsolete]//I don't think we need this... but let's keep for legacy for now
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDateTime { get; set; }

        [Obsolete]//I don't think we need this... but let's keep for legacy for now
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DropOffDateTimeLocal { get; set; }

        public string DropOffDateTimeZone { get; set; }
        public string DropOffDateTimeZoneShortName { get; set; }
        public int? DropOffDateTimeZoneId { get; set; }

        public string Description { get; set; }
        public string Dimensions { get; set; }
        public int? Weight { get; set; }
        public int? NetWeight { get; set; }
        public int? UnitOfMeasureId { get; set; }
        public string UnitOfMeasure { get; set; }
        public string InvoiceNumber { get; set; }
        public int? PalletCount { get; set; }
        public int? CrateCount { get; set; }
        public bool? IsOversizedLoad { get; set; }
        public int? VehicleTrailorTypeId { get; set; } //TODO: rename
        public string VehicleTrailorType { get; set; } //TODO: rename
        public int? ShipmentPaymentTypeId { get; set; } //TODO: rename
        public string ShipmentPaymentType { get; set; } //TODO: rename
        public int? TruckLoadTypeId { get; set; }
        public string TruckLoadType { get; set; }
        public int ShipmentStatusId { get; set; }
        public string ShipmentStatus { get; set; }
        public string Status { get; set; }
        public int? ShipmentRequestStatusId { get; set; }
        public string ShipmentRequestStatus { get; set; }
        public int? RequiresTwicCard { get; set; }
        public string ContractTemplateIdentifier { get; set; }
        public decimal? ShipmentPaymentRate { get; set; } //TODO: rename
        public decimal? FuelSurcharge { get; set; }
        public bool FuelSurchargeIncluded { get; set; }
        public decimal? EstTotal { get; set; }
        public ProfileMessage Driver { get; set; }
        public ProfileMessage AwardedTo { get; set; }
        public string ShortIdentifier => string.IsNullOrWhiteSpace(Identifier) ? string.Empty : Identifier.Substring(0, 8);
        public int? Distance { get; set; } //In Meters
        public int? Duration { get; set; } //In seconds
        public string DurationDisplay { get; set; }
        public string MapUrl { get; set; }
        public bool ReadOnly { get; set; }
        public decimal? CounterShipmentPaymentRate { get; set; }
        public decimal? CounterShipmentEstTotal { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? RequestedDate { get; set; }
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? RequestedDateTimeLocal { get; set; }

        public bool QuickPayEligible { get; set; }

        public InvoiceMessage Invoice { get; set; }

        public IEnumerable<GenericListMessage<int>> Damages { get; set; }

        public string ReceiverSignature { get; set; }
        public string ReceiverName { get; set; }
    }
}
