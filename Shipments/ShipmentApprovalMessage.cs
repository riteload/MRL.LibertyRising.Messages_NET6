using System.ComponentModel.DataAnnotations;

namespace MRL.LibertyRising.Messages.Shipments
{
    public class ShipmentApprovalMessage
    {
        public string Identifier { get; set; }

        [Display(Name = "Approval Type")]
        public int ApprovalTypeId { get; set; }
        
        [Display(Name = "Approval Sub Type")]
        public int? ApprovalSubTypeId { get; set; }

        [Display(Name = "Approval Data")]
        public string ApprovalData { get; set; }
    }
}