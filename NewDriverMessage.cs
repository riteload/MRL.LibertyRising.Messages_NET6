using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages
{
    public class NewDriverMessage: NewAccountMessage
    {
        [Required]
        public string DriverLicenseNumber { get; set; }

        [Range(1, int.MaxValue)]
        public int DriverLicenseStateId { get; set; }

        //[JsonConverter(typeof(BoolConverter))]
        [Range(0,1)]
        public int HasTwicCard { get; set; }

        [Required]
        public string CompanyDotNumber { get; set; }

        [Required]
        public string CompanyMcNumber { get; set; }

        [Range(1, int.MaxValue)]
        public int CompanyTypeId { get; set; }

        [Range(1, int.MaxValue)]
        [JsonProperty(PropertyName= "makeId")]
        public int VehicleMakeId { get; set; }

        [Range(1, int.MaxValue)]
        [JsonProperty(PropertyName = "modelId")]
        public int VehicleModelId { get; set; }

        [Range(1900, 3000)]
        [JsonProperty(PropertyName = "year")]
        public int VehicleYear { get; set; }

        [Required]
        public string VehicleVinNumber { get; set; }

        [Range(1, int.MaxValue)]
        public int VehicleStateId { get; set; }

        [Range(1, int.MaxValue)]
        public int VehicleTrailorTypeId { get; set; }

        [Required]
        public string InsuranceCompanyName { get; set; }

        [Required]
        public string InsurancePolicyNumber { get; set; }

        [Required]
        public string InsuranceAgentFirstName { get; set; }

        [Required]
        public string InsuranceAgentLastName { get; set; }

        [Required]
        //[Phone]
        public string InsuranceAgentPhoneNumber { get; set; }

        public string InsuranceCertificateIdentifier { get; set; }

        public string OriginalFileName { get; set; }

        public string Password { get; set; }
    }
}
