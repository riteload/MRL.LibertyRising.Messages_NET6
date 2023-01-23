using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Contracts
{
    public class ContractTemplateMessage
    {
        public string Identifier { get; set; }
        public string Extension { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public string Handle { get; set; }
        public string OriginalFileName { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime DateCreated { get; set; }
    }
}
