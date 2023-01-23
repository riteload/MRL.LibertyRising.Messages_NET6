using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages.Ratings
{
    public class RatingSearchFilter
    {
        public decimal? Rating { get; set; }

        public bool? IsLower { get; set; }

    }
}
