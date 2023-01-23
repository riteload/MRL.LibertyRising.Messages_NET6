namespace MRL.LibertyRising.Messages
{
    public class CompanyMessage
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string PostalCode { get; set; }
        public string DotNumber { get; set; }
        public string McNumber { get; set; }
        public string Ein { get; set; }
        public int? CompanyTypeId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public VehicleMessage Vehicle { get; set; }
        public InsuranceMessage Insurance { get; set; }
    }
}
