using System.Collections.Generic;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class WarehouseMessage
    {
        public string Identifier { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int CountryId { get; set; }
        public int LocationTypeId { get; set; }
        public string LocationType { get; set; }
        public string CompanyIdentifier { get; set; }
        public IEnumerable<DockMessage> Docks { get; set; }
        public string Country { get; set; }
        public int LocationStatusId { get; set; }
        public string LocationStatus { get; set; }
        public string Contact { get; set; }
    }
}
