using Newtonsoft.Json;

namespace MRL.LibertyRising.Messages
{
    public class SignInResultMessage
    {
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty(PropertyName = "expires_on")]
        public int ExpiresOn { get; set; }

        [JsonProperty(PropertyName = "user_type_id")]
        public int UserTypeId { get; set; }

        [JsonProperty(PropertyName = "user_type_name")]
        public string UserTypeName { get; set; }
    }
}
