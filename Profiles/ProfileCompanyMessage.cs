using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRL.LibertyRising.Messages.Profiles
{
    public class ProfileCompanyMessage
    {
        public string Identifier { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string PostalCode { get; set; }
        public string DotNumber { get; set; }
        public string McNumber { get; set; }
        public string Ein { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
