using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Notifications
{
    [Obsolete]
    public class NotificationDetailMessage
    {
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
        public string ActorPhotoHandle { get; set; }
        public string ActorIdentifier { get; set; }
        public string ObjectIdentifier { get; set; }
        public string ObjectShortIdentifier { get; set; }
        public int NotificationTypeId { get; set; }
        public string NotificationType { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime NotificationDate { get; set; }
    }
}
