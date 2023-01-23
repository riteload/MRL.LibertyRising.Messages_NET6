using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages
{
    public class SignInMessage
    {
        public string Username { get; set; }
        public string Password { get; set; }

        [JsonProperty(PropertyName="grant_type")]
        public string GrantType { get; set; }
    }
}
