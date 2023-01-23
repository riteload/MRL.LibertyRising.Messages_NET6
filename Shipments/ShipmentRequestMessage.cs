using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;
using System;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentRequestMessage
    {
        public ProfileMessage Driver { get; set; }
        public ShipmentMessage Shipment { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public decimal? CounterPaymentRate { get; set; }
        public decimal? CounterEstTotal{ get; set; }
        public int? CounterPaymentTypeId { get; set; }
        public string CounterPaymentType { get; set; }

        public string RequestedDateTimeZone { get; set; }
        public string RequestedDateTimeZoneShortName { get; set; }
        public int? RequestedDateTimeZoneId { get; set; }

        public bool QuickPayRequested { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? RequestedDate { get; set; }
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? RequestedDateTimeLocal { get; set; }
    }
}
