using System;
using System.Collections.Generic;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Notifications
{
    public class NotificationMessage
    {
        public ProfileMessage From { get; set; }
        public ProfileMessage To { get; set; }
        public string Identifier { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public IDictionary<string, string> Data { get; set; }
        public string NotificationType { get; set; }
        public int NotificationTypeId { get; set; }
        public bool Unread { get; set; }

        #region Properties required for old driver application
        [Obsolete]
        public string ActorFirstName { get; set; }
        [Obsolete]
        public string ActorLastName { get; set; }
        [Obsolete]
        public string ActorPhotoHandle { get; set; }
        [Obsolete]
        public string ObjectIdentifier { get; set; }
        [Obsolete]
        public string ObjectShortIdentifier { get; set; } 
        #endregion

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime DateSent { get; set; }
    }
}
