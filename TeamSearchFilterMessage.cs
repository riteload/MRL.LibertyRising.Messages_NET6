namespace MRL.LibertyRising.Messages
{
    public class TeamSearchFilterMessage
    {
        public string Name { get; set; }
        public int[] StatusIds { get; set; }

        public TeamSearchFilterMessage()
        {
            StatusIds = new int[] {};
        }
    }
}
