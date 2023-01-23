namespace MRL.LibertyRising.Messages.QuickPay
{
    public class QuickPayUserMessage : QuickPayApplicationMessage
    {
        public decimal Open { get; set; }
        public decimal Booked { get; set; }
    }
}
