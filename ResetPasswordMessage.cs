namespace MRL.LibertyRising.Messages
{
    public class ResetPasswordMessage
    {
        public string Token { get; set; }
        public string Password { get; set; }
    }
}
