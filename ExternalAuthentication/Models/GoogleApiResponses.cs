
using Newtonsoft.Json;

namespace ExternalAuthentication.Models
{
    internal class GoogleUserData
    {

        [JsonProperty("azp")]
        public string ClientId { get; set; }

        [JsonProperty("iat")]
        public long Id { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("given_name")]
        public string FirstName { get; set; }
        [JsonProperty("family_name")]
        public string LastName { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("picture")]
        public string Picture { get; set; }
        [JsonProperty("email_verified")]
        public bool IsVerified { get; set; }
    }
}
