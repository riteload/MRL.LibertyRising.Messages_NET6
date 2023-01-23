using System.Collections.Generic;

namespace MRL.LibertyRising.Messages.Support
{
    public class SupportTicketMessage
    {
        public long? Identifier { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Requester Requester { get; set; }
        public string PermaLink { get; set; }
        public DeviceInfo Device { get; set; }
        public string Via { get; set; }
        public List<string> Tags { get; set; }
        public string TicketType { get; set; }
        public string Status { get; set; }

        public SupportTicketMessage()
        {
            Requester = new Requester();
            Tags = new List<string>();
        }
    }
}
