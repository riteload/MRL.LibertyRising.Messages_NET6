using System;
using MRL.LibertyRising.Messages.Ratings;

namespace MRL.LibertyRising.Messages
{
    public class ProfileMessage
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identifier { get; set; }
        public int UserTypeId { get; set; }
        public string UserType { get; set; }
        public string Bio { get; set; }
        public string PhotoUrl { get; set; }
        public UserRatingMessage Rating { get; set; }
        public string Initials { get; set; }

        public int? DriverLicenseStateId { get; set; }
        public string DriverLicenseState { get; set; }
        public string HasTwicCard { get; set; }
        public string DotNumber { get; set; }
        public string McNumber { get; set; }
        public string Ein { get; set; }

        public string CompanyName { get; set; }
        public string CompanyIdentifier { get; set; }
        public int? CompanyTypeId { get; set; }
        public string CompanyType { get; set; }
        public string CompanyState { get; set; }

        public string VehicleType { get; set; }
        public int? VehicleYear { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleInsuranceCertificatePath { get; set; }

        public string CompanyPhoneNumber { get; set; }
        public string Email { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyPostalCode { get; set; }
        public string[] Claims { get; set; }

        public string QuickPayStatus { get; set; }
        public int? QuickPayStatusId { get; set; }

        public int? QuickPayApplicationStatusId { get; set; }
        public string QuickPayApplicationStatus { get; set; }
    }
}
