using System.Collections.Generic;

namespace MRL.LibertyRising.Messages.Notifications
{
    public class NotificationAggregateMessage
    {
        public int NotificationTypeId { get; set; }
        public string NotificationType { get; set; }
        public int Count { get; set; }
        public IEnumerable<ProfileMessage> Actors { get; set; }
        public IDictionary<string, string> Data { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
