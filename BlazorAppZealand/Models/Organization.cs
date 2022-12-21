using Newtonsoft.Json;

namespace BlazorAppZealand.Models
{
    public class Organization
    {
        [JsonProperty("id")]
        public string id { get; set; }
        
        [JsonProperty("domain_name")]
        public string DomainName { get; set; }
        
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }
        
        [JsonProperty("primary_email")]
        public string PrimaryEmail { get; set; }
        
        [JsonProperty("zip")]
        public string Zip { get; set; }
        
        [JsonProperty("state")]
        public string State { get; set; }
        
        [JsonProperty("street")]
        public string Street { get; set; }
        
        [JsonProperty("city")]
        public string City { get; set; }
        
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
