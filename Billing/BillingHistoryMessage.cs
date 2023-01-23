using System;
using MRL.LibertyRising.Messages.Converters;
using MRL.LibertyRising.Messages.Shipments;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Billing
{
    public class BillingHistoryMessage
    {
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string CreditCardLastFour { get; set; }
        public string CreditCardType { get; set; }
        public int? SubscriptionTypeId { get; set; }
        public string SubscriptionType { get; set; }
        public string TransactionType { get; set; } //TODO this is getting set to the wrong value
        public string TransactionStatus { get; set; }
        public string Merchant { get; set; }
        public string ShipmentIdentifier { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime BillingPeriodStart { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime TransactionDate { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime BillingPeriodEnd { get; set; }

        public ShipmentMessage Shipment { get; set; }
    }
}
