using System;

namespace MRL.LibertyRising.Messages
{
    [Obsolete]
    public class AdminProfileMessage : ProfileMessage
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string DriverLicenseNumber { get; set; }

        public string CompanyPhoneNumber { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyEin { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }
        public int CompanyStateId { get; set; }
        public string CompanyState { get; set; }
        public string CompanyPostalCode { get; set; }
    }
}