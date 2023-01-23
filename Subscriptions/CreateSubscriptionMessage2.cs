using System;

namespace MRL.LibertyRising.Messages.Subscriptions
{
    
    public class CreateSubscriptionMessage2
    {
        public string Nonce { get; set; }
        public int SubscriptionConfigurationId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentInstrument { get; set; }
        public string PaymentLastTwo { get; set; }
        public string RegistrationIdentifier { get; set; }
    }
}
