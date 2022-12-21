using Newtonsoft.Json;

namespace BlazorAppZealand.Models;

public class ResponseOrgJson
{
    [JsonProperty("org")]
    public List<Organization> Organizations { get; set; }
}