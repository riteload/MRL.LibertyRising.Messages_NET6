using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Subscriptions
{
    public class SubscriptionConfigurationMessage
    {
        [JsonProperty(PropertyName="id")]
        public long SubscriptionConfigurationId { get; set; }
        public string Name { get; set; }
        public decimal SubscriptionAmount { get; set; }
        public decimal PerTransactionAmount { get; set; }
        public decimal BackgroundCheckAmount { get; set; }
    }
}
