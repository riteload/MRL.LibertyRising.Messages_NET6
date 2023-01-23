namespace MRL.LibertyRising.Messages.Documents
{
    public class DocumentInfoMessage
    {
        public string FileName { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public bool IsPublic { get; set; }
        public string PublicUri { get; set; }
        public string Handle { get; set; }
    }
}
