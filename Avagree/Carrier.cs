using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Avagree
{
    public class Carrier
    {
        public string OperatingStatus { get; set; }
        public string CommonAuthorityStatus { get; set; }
        public string ContractAuthorityStatus { get; set; }
        public string BrokerAuthorityStatus { get; set; }
        public string LegalName { get; set; }
        public string SafetyRating { get; set; }

        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? SafetyRatingDate { get; set; }

        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? ContractAuthorityStatusDate { get; set; }

        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? CommonAuthorityStatusDate { get; set; }

        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? BrokerAuthorityStatusDate { get; set; }
    }
}