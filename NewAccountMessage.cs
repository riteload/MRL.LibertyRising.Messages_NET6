namespace MRL.LibertyRising.Messages
{
    public class NewAccountMessage
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string DriverLicenseNumber { get; set; }
        public int? DriverLicenseStateId { get; set; }
        public int? HasTwicCard { get; set; }
        public string Username { get; set; }
        public string UserIdentifier { get; set; }
        public string AccountIdentifier { get; set; }
        public string PasswordHash { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEin { get; set; }
        public string CompanyEmail { get; set; }
        public int? CompanyTypeId { get; set; }
        public string CompanyMcNumber { get; set; }
        public string CompanyDotNumber { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }
        public int? CompanyStateId { get; set; }
        public string CompanyPostalCode { get; set; }
        public string CompanyIdentifier { get; set; }
        public int? VehicleYear { get; set; }
        public int? VehicleMakeId { get; set; }
        public int? VehicleModelId { get; set; }
        public string VehicleVinNumber { get; set; }
        public int? VehicleStateId { get; set; }
        public int? VehicleTrailorTypeId { get; set; }
        public string InsuranceCompanyName { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string InsuranceAgentFirstName { get; set; }
        public string InsuranceAgentLastName { get; set; }
        public string InsuranceAgentPhoneNumber { get; set; }
        public string InsuranceCertificateHandle { get; set; }
        public string InsuranceCertificateFileName { get; set; }
        public int UserTypeId { get; set; }
        public string MerchantToken { get; set; }
        public int? SubscriptionConfigurationId { get; set; }
        public string PasswordSalt { get; set; }
    }
}
