using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Registration
{
    public class DispatchDriverVehicleMessage
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
    }
}
