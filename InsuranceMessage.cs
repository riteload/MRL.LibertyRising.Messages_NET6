using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages
{
    public class InsuranceMessage
    {
        public string Identifier { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string PolicyNumber { get; set; }
        public string AgentFirstName { get; set; }
        public string AgentLastName { get; set; }
        public string AgentPhoneNumber { get; set; }
        public string CertificateUrl { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        [Display(Name = "Expiration Date")]
        public DateTime? ExpirationDate { get; set; }
    }
}
