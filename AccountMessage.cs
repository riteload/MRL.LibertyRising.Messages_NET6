using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages
{
    public class AccountMessage
    {
        public string Identifier { get; set; } //TODO: rename to accountIdentifier
        public string UserIdentifier { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime  DateCreated { get; set; }
    }
}
