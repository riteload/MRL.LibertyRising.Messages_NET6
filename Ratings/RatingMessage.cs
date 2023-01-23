using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Ratings
{
    public class RatingMessage
    {
        public string ShipmentIdentifier { get; set; }
        public string ChoiceIdentifier { get; set; }

        [JsonIgnore]
        public string RatedByIdentifier { get; set; }
    }
}
