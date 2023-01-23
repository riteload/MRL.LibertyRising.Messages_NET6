using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentLocationMessage
    {
        public string Address { get; set; }

        public string City { get; set; }

        [Display(Name = "State")]
        public int? StateId { get; set; }

        public string StateName { get; set; }

        public string StateAbbreviation { get; set; }

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        public int CountryId { get; set; }

        public string CountryName { get; set; }

        public string WarehouseIdentifier { get; set; }

        public string DockIdentifier { get; set; }

        public string Contact { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }
    }
}
