namespace BlazorAppZealand.Models;

public class ZohoToken
{
    public string refresh_token { get; set; }
    
    public string client_id { get; set; }
    
    public string client_secret { get; set; }
    
    public string grant_type { get; set; }
}