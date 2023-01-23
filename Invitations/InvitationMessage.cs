using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Invitations
{
    public class InvitationMessage
    {
        public string Code { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string CompanyIdentifier { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int InvitationTypeId { get; set; }
        public string InvitationType { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime DateExpires { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime DateSent { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? DateAccepted { get; set; }
    }
}
