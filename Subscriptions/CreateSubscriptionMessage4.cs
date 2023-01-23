using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRL.LibertyRising.Messages.Subscriptions
{
    [Obsolete("Potential Future Use, us CreateSubscriptionMessage2")]
    public class CreateSubscriptionMessage4
    {
        public string Nonce { get; set; }
        public int SubscriptionConfigurationId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentInstrument { get; set; }
        public string PaymentLastTwo { get; set; }
    }
}
