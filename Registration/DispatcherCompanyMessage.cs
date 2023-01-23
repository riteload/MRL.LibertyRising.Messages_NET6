using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Registration
{
    public class DispatcherCompanyMessage
    {
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Company Email")]
        public string CompanyEmail { get; set; }

        [Display(Name = "Company Phone Number")]
        public string CompanyPhoneNumber { get; set; }

        [Display(Name = "Company EIN")]
        public string CompanyEin { get; set; }

        //[Display(Name = "Company Type")]
        //public int? CompanyTypeId { get; set; }

        [Display(Name = "MC Number")]
        public string CompanyMcNumber { get; set; }

        [Display(Name = "DOT Number")]
        public string CompanyDotNumber { get; set; }

        [Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }

        [Display(Name = "Company City")]
        public string CompanyCity { get; set; }
        
        [Display(Name ="Company State")]
        public int? CompanyStateId { get; set; }

        [Display(Name = "Company Zip Code")]
        public string CompanyPostalCode { get; set; }
    }
}
