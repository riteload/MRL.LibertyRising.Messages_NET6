using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRL.LibertyRising.Messages.Accounts
{
    public class AccountFromExternalMessage : NewAccountMessage
    {
        public string Password { get; set; }
        public string CompanyStateName { get; set; }
        public string AccountOriginName { get; set; }
        public string ShipperUserIdentifier{ get; set; }

        //hiding base UserTypeId so it is not expressed in controller response unless a value is set
        new public int? UserTypeId { get; set; }
    }
}
