using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRL.LibertyRising.Messages.Notifications
{
    public class ExternalNotificationMessage
    {
        public string ShipmentIdentifier { get; set; }
        public string ShipperUserIdentifier { get; set; }
        public string NotificationType { get; set; }
        public ExternalDriver Driver { get; set; }
    }

    public class ExternalDriver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Bio { get; set; }
        public string LicenseNumber { get; set; }
        public string LicenseState { get; set; }
        public ExternalCompany Carrier { get; set; }

    }


    public class ExternalCompany
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Ein { get; set; }
        public string McNumber { get; set; }
        public string DotNumber { get; set; }
        public string Rating { get; set; }

    }
}


