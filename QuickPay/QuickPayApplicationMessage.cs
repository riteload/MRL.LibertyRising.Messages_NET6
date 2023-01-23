using System;

namespace MRL.LibertyRising.Messages.QuickPay
{
    public class QuickPayApplicationMessage
    {
        public int ApplicantTypeId { get; set; }
        public string ApplicantType { get; set; }
        public string Identifier { get; set; }
        public string BusinessName { get; set; }
        public string FeinNumber { get; set; }
        public string McNumber { get; set; }
        public int ApplicationStatusId { get; set; }
        public string ApplicationStatus { get; set; }
        public int AccountStatusId { get; set; }
        public string AccountStatus { get; set; }
        public DateTime Date { get; set; }
    }
}
