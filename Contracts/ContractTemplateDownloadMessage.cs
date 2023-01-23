using System.IO;

namespace MRL.LibertyRising.Messages.Contracts
{
    public class ContractTemplateDownloadMessage
    {
        public string FileName { get; set; }
        public string Handle { get; set; }
        public Stream File { get; set; }
    }
}