namespace MRL.LibertyRising.Messages.Accounts
{
    public class UserCountMessage
    {
        public int UserTypeId { get; set; }
        public string UserType { get; set; }
        public int Count { get; set; }
    }
}
