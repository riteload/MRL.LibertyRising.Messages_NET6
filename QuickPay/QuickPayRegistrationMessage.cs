namespace MRL.LibertyRising.Messages.QuickPay
{
    public class QuickPayRegistrationMessage
    {
        public int? ApplicationTypeId { get; set; }
        public string UserIdentifier { get; set; }
        public QuickPayRegistrationDataMessage Data { get; set; }
    }
}
