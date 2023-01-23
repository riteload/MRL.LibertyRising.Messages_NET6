namespace MRL.LibertyRising.Messages.Billing
{
    public class CreditCardMessage
    {
        public string MaskedNumber { get; set; }
        public string LastFour { get; set; }
        public string CardType { get; set; }
        public string ExpirationDate { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public bool IsExpired { get; set; }
    }
}
