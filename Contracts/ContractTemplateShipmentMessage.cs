using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Contracts
{
    public class ContractTemplateShipmentMessage
    {
        public string Title { get; set; }
        public string ShipmentIdentifier { get; set; }
        public string ShipmentShortIdentifier => string.IsNullOrWhiteSpace(ShipmentIdentifier) ? string.Empty : ShipmentIdentifier.Substring(0, 8);
        public string ShipmentOriginAddress { get; set; }
        public string DriverIdentifier { get; set; }
        public string DriverFirstName { get; set; }
        public string DriverLastName { get; set; }
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime DateSigned { get; set; }
    }
}
