using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BlazorAppZealand.Models
{
    public class Contact
    {
        [JsonProperty("id")]
        public string id { get; set; }
        
        [JsonProperty("First_Name")]
        [Required]
        public string First_Name { get; set; }

        [JsonProperty("Last_Name")]
        [Required]
        public string Last_Name { get; set; }
        
        [JsonProperty("Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [JsonProperty("Phone")]
        [Required]
        public string Phone { get; set; }
        
        [JsonProperty("Mobile")]
        public string Mobile { get; set; }
        
        [JsonProperty("Title")]
        public string Title { get; set; }
        
        [JsonProperty("Secondary_Email")]
        public string Secondary_Email { get; set; }
        
        [JsonProperty("Account_Name")]
        public AccountName Account_Name { get; set; }
    }
}
