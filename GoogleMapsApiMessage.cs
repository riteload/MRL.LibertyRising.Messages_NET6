namespace MRL.LibertyRising.Messages
{
    public class GoogleMapsApiMessage
    {
        public string Summary { get; set; }
        public string ArrivalTimeText { get; set; }
        public string ArrivalTimeValue { get; set; }
        public string DepartureTimeText { get; set; }
        public string DepartureTimeValue { get; set; }
        public string DistanceText { get; set; }
        public string DistanceValue { get; set; }
        public string DurationText { get; set; }
        public string DurationValue { get; set; }
        public string StartAddress { get; set; }
        public double? StartLocationLatitude { get; set; }
        public double? StartLocationLongitude { get; set; }
        public string EndAddress { get; set; }
        public double? EndLocationLatitude { get; set; }
        public double? EndLocationLongitude { get; set; }

    }
}
