namespace MRL.LibertyRising.Messages
{
    public class PasswordResetMessage
    {
        public string Token { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
