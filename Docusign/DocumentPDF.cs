using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Docusign
{
    [DataContract(Name = "DocumentPDF")]
    public class DocumentPdf
    {
        public string Name { get; set; }

        [JsonProperty("PDFBytes")]
        public string PdfBytes { get; set; }
    }
}