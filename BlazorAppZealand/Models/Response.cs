using Newtonsoft.Json;

namespace BlazorAppZealand.Models;

public class Response
{
    [JsonProperty("data")]
    public List<Contact> Contacts { get; set; }
}