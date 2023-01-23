using System;

namespace MRL.LibertyRising.Messages.Subscriptions
{
    [Obsolete("Use CreateSubscriptionMessage2")]
    public class CreateSubscriptionMessage
    {
        public string Nonce { get; set; }
        public int SubscriptionConfigurationId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentInstrument { get; set; }
        public string PaymentLastTwo { get; set; }
        public string AccountIdentifier { get; set; }
    }
}
