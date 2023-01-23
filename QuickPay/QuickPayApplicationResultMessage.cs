using System;

namespace MRL.LibertyRising.Messages.QuickPay
{
    public class QuickPayApplicationResultMessage
    {
        public bool Successful { get; set; }
        public QuickPayApplicationMessage QuickPayApplication { get; set; }
    }
}
