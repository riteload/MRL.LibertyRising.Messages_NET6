using System;
using MRL.LibertyRising.Messages.Converters;
using MRL.LibertyRising.Messages.Shipments;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Invoices
{
    public class InvoiceMessage
    {
        public ShipmentMessage Shipment { get; set; }
        public string InvoiceNumber { get; set; }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public decimal OriginalAmount { get; set; }

        public decimal OriginalDistance { get; set; }

        public decimal? ResolutionAmount { get; set; }

        public decimal? ResolutionDistance { get; set; }

        //public string ResolutionDescription { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? ResolutionDate { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime InvoiceDate { get; set; }
    }
}
