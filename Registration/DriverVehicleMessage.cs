
using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Registration
{
    public class DriverVehicleMessage
    {
        [Display(Name = "Year")]
        public int? VehicleYear { get; set; }

        [Display(Name = "Make")]
        public int? VehicleMakeId { get; set; }

        [Display(Name = "Model")]
        public int? VehicleModelId { get; set; }

        [Display(Name = "Vin Number")]
        public string VehicleVinNumber { get; set; }

        [Display(Name = "State" )]
        public int? VehicleStateId { get; set; }

        [Display(Name = "Trailer Type")]
        public int? VehicleTrailorTypeId { get; set; }

        [Display(Name = "Insurance Company")]
        public string InsuranceCompanyName { get; set; }

        [Display(Name = "Insurance Policy")]
        public string InsurancePolicyNumber { get; set; }

        [Display(Name = "Agent First Name")]
        public string InsuranceAgentFirstName { get; set; }

        [Display(Name = "Agent Last Name")]
        public string InsuranceAgentLastName { get; set; }

        [Display(Name = "Agent Phone Number")]
        public string InsuranceAgentPhoneNumber { get; set; }

        [Display(Name = "Insurance Certificate Handle")]
        public string InsuranceCertificateHandle { get; set; }

        [Display(Name = "Insurance Certificate File Name")]
        public string InsuranceCertificateFileName { get; set; }
    }
}
