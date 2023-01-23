namespace MRL.LibertyRising.Messages.Accounts
{
    public class UpdatePasswordMessage
    {
        public string NewPassword { get; set; }
        public string CurrentPassword { get; set; }
    }
}
