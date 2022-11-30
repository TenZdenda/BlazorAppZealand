using Newtonsoft.Json;

namespace BlazorAppZealand.Models
{
    public class Contact
    {
        [JsonProperty("id")]
        public string id { get; set; }
        
        [JsonProperty("First_Name")]
        public string FirstName { get; set; }
        
        [JsonProperty("Last_Name")]
        public string LastName { get; set; }
        
        [JsonProperty("Email")]
        public string Email { get; set; }
        
        [JsonProperty("Phone")]
        public string Phone { get; set; }
        
        [JsonProperty("Mobile")]
        public string Mobile { get; set; }
        
        [JsonProperty("Title")]
        public string Title { get; set; }
        
        [JsonProperty("Secondary_Email")]
        public string Secondary_Email { get; set; }
    }
}
