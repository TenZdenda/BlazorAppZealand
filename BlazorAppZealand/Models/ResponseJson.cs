using Newtonsoft.Json;

namespace BlazorAppZealand.Models;

public class ResponseJson
{
    [JsonProperty("data")]
    public Contact Contact { get; set; }
}