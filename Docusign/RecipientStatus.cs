using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Docusign
{
    public class RecipientStatus
    {
        public string Type { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string RoutingOrder { get; set; }
        public string Sent { get; set; }
        public string Delivered { get; set; }
        public DeclineReason DeclineReason { get; set; }
        public string Status { get; set; }

        [JsonProperty("RecipientIPAddress")]
        public string RecipientIpAddress { get; set; }
        public object CustomFields { get; set; }
        //public IEnumerable<TabStatus> TabStatuses { get; set; }
        public string AccountStatus { get; set; }
        public string RecipientId { get; set; }
    }
}