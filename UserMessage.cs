using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages
{
    public class UserMessage
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string EmailAddress { get; set; }
        public string Identifier { get; set; }
        public int UserTypeId { get; set; }
        public string UserType { get; set; }
        public string Bio { get; set; }
        public string PhotoHandle { get; set; }

        [JsonProperty("mobilePhone")]
        public string PhoneNumber { get; set; }
        public string DriverLicenseNumber { get; set; }
        public int? DriverLicenseStateId { get; set; }
        public int HasTwicCard { get; set; }

        public CompanyMessage Company { get; set; }
    }
}
