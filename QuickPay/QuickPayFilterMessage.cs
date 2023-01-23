using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRL.LibertyRising.Messages.QuickPay
{
    public class QuickPayFilterMessage
    {
        public int? ApplicantTypeId { get; set; }
        public string Query { get; set; }
    }
}
