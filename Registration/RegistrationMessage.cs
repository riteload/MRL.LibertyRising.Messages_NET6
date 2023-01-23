namespace MRL.LibertyRising.Messages.Registration
{
    public class RegistrationMessage
    {
        public string Identifier { get; set; }
        public string LookupToken { get; set; }
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public int LastStepCompleted { get; set; }
    }
}
