namespace MRL.LibertyRising.Messages.Preferences
{
    public class PreferredLaneMessage
    {
        public int StateId { get; set; }
        public string StateName { get; set; }

        public string StateAbbreviation { get; set; }
        public bool Origin { get; set; }
        public bool Destination { get; set; }
    }
}
