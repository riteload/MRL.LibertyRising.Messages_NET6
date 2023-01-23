using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Docusign
{
    public class DocumentStatus
    {
        [JsonProperty("ID")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string TemplateName { get; set; }
        public string Sequence { get; set; }
    }
}