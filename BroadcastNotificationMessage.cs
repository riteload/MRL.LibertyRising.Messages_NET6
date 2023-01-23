using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages
{
    [Obsolete("Pretty sure we can delete this")]
    public class BroadcastNotificationMessage
    {
        public string Text { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime DateTime { get; set; }

        public BroadcastNotificationMessage()
        {
            Text = "You have a new message";
        }
    }
}
