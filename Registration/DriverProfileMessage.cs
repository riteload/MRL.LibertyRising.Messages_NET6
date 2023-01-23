using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Registration
{
    public class DriverProfileMessage
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }

        [Display(Name = "Driver's License Number")]
        public string DriverLicenseNumber { get; set; }

        [Display(Name = "State")]
        public int? DriverLicenseStateId { get; set; }

        [Display(Name = "TWIC Card")]
        public int? HasTwicCard { get; set; }

        public string Bio { get; set; }
    }
}
