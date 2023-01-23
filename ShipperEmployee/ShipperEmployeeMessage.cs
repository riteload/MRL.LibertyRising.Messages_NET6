using System;
using MRL.LibertyRising.Messages.Converters;
using Newtonsoft.Json;


namespace MRL.LibertyRising.Messages.ShipperEmployee
{
    public class ShipperEmployeeMessage
    {
        public string Identifier { get; set; }
        public bool IsUser { get; set; }
        public string Status { get; set; }
        public int StatusId { get; set; }
        public string Username { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime Date { get; set; }
    }
}
