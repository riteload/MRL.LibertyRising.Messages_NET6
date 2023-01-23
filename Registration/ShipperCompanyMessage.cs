
using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Registration
{
    public class ShipperCompanyMessage
    {
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Company EIN")]
        public string CompanyEin { get; set; }

        [Display(Name = "Company Email")]
        public string CompanyEmail { get; set; }

        [Display(Name = "Company Phone")]
        public string CompanyPhoneNumber { get; set; }

        [Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }

        [Display(Name = "Company City")]
        public string CompanyCity { get; set; }

        [Display(Name = "Company State")]
        public int? CompanyStateId { get; set; }

        //[Display(Name = "Company Type")]
        //public int? CompanyTypeId { get; set; }

        [Display(Name = "Company Postal Code")]
        public string CompanyPostalCode { get; set; }
    }
}
