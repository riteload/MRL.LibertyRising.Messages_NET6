using System.Collections.Generic;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Avagree
{
    public class Warnings
    {
        [JsonProperty(PropertyName = "warnings")]
        public List<string> WarningsList { get; set; }
    }
}