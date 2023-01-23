namespace MRL.LibertyRising.Messages.Billing
{
    public class UpdatePaymentMethodMessage
    {
        public string Nonce { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentInstrument { get; set; }
        public string PaymentLastTwo { get; set; }
    }
}
