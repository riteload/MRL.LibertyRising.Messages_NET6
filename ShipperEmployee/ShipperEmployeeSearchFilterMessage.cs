

namespace MRL.LibertyRising.Messages
{
    public class ShipperEmployeeSearchFilterMessage
    {
        public string Name { get; set; }
        public int[] StatusIds { get; set; }

        public ShipperEmployeeSearchFilterMessage()
        {
            StatusIds = new int[] { };
        }
    }
}
