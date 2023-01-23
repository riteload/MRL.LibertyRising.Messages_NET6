using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Docusign
{
    public class EnvelopeStatus
    {
        public RecipientStatuses RecipientStatuses { get; set; }
        public string TimeGenerated { get; set; }

        [JsonProperty("EnvelopeID")]
        public string EnvelopeId { get; set; }
        public string Subject { get; set; }
        public string UserName { get; set; }

        [JsonProperty]
        public string Email { get; set; }
        public string Status { get; set; }
        public string Created { get; set; }
        public string Sent { get; set; }
        public string Delivered { get; set; }

        [JsonProperty("ACStatus")]
        public string AcStatus { get; set; }

        [JsonProperty("ACStatusDate")]
        public string AcStatusDate { get; set; }

        [JsonProperty("ACHolder")]
        public string AcHolder { get; set; }

        [JsonProperty("ACHolderEmail")]
        public string AcHolderEmail { get; set; }

        [JsonProperty("ACHolderLocation")]
        public string AcHolderLocation { get; set; }
        public string SigningLocation { get; set; }

        [JsonProperty("SenderIPAddress")]
        public string SenderIpAddress { get; set; }

        [JsonProperty("EnvelopePDFHash")]
        public object EnvelopePdfHash { get; set; }
        //public IEnumerable<CustomField> CustomFields { get; set; }
        public bool AutoNavigation { get; set; }
        public bool EnvelopeIdStamping { get; set; }
        public bool AuthoritativeCopy { get; set; }
        //public IEnumerable<DocumentStatus> DocumentStatuses { get; set; }
    }
}