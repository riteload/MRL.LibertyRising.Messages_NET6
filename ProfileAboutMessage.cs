namespace MRL.LibertyRising.Messages
{
    public class ProfileAboutMessage
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoHandle { get; set; }

        public string Email { get; set; }
        public string Identifier { get; set; }
        public string Bio { get; set; }

        public string MobilePhone { get; set; }
        public string DriverLicenseNumber { get; set; }
        public int? DriverLicenseStateId { get; set; }
        public string DriverLicenseState { get; set; }
        public int? HasTwicCard { get; set; }
    }
}
