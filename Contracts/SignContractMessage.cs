
namespace MRL.LibertyRising.Messages.Contracts
{
    public class SignContractMessage
    {
        public string Signature { get; set; }
        public string ShipmentIdentifier { get; set; }
        public string DriverIdentifier { get; set; }
        public string ClientTimezone { get; set; }
    }
}
