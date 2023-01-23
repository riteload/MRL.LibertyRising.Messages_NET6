using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Docusign
{
    public class TabStatus
    {
        public string TabType { get; set; }
        public string Status { get; set; }
        public string XPosition { get; set; }
        public string YPosition { get; set; }
        public string TabLabel { get; set; }
        public string TabName { get; set; }
        public object TabValue { get; set; }

        [JsonProperty("DocumentID")]
        public string DocumentId { get; set; }
        public string PageNumber { get; set; }
        public object OriginalValue { get; set; }
        public object ValidationPattern { get; set; }
        public string RoleName { get; set; }
    }
}