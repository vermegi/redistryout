using Newtonsoft.Json;

namespace FunctionApp1
{
    public class ContactInformation
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string TelephoneNumber { get; set; }
    }
}