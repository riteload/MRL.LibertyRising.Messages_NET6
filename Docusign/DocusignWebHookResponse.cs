using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Docusign
{
    public class DocusignWebHookResponse
    {
        [JsonProperty("DocuSignEnvelopeInformation")]
        public DocusignEnvelopeInformation DocusignEnvelopeInformation { get; set; }
    }
}
