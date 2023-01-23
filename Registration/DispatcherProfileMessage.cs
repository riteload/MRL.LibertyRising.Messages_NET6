using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Registration
{
    public class DispatcherProfileMessage
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Mobile Phone")]
        public string MobilePhone { get; set; }
        
        public string Bio { get; set; }
    }
}
