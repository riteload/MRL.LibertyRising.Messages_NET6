using MRL.LibertyRising.Messages.Shipments;

namespace MRL.LibertyRising.Messages.Preferences
{
    public class SavedLoadboardSearchFilterMessage
    {
        public string Name { get; set; }
        public int FilterTypeId { get; set; }
        public string FilterTypeName { get; set; }
        public ShipmentSearchFilter Filter { get; set; }
    }
}
