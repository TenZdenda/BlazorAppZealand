using System.Text;
using BlazorAppZealand.Models;
using Newtonsoft.Json;

namespace BlazorAppZealand;

public class AddHeadersDelegatingHandler : DelegatingHandler
{
    public AddHeadersDelegatingHandler() : base(new HttpClientHandler())
    { }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        /*var token = "";
        
        var postBody = new
        {
            ZohoToken = new ZohoToken()
            {
                client_id = "1000.a8cb07878c0c33db883bcf5c37280bcf.5c8ee91aee382c6f7f88515a8b2ecb94",
                client_secret = "1000.SBE9PNBZXWHKOLAUSWNNBHM7XVQLIC",
                grant_type = "f3bda5b652a1ba6e83b7d70798421bf29dcdd91c06",
                refresh_token = "refresh_token"
            }
        };
        
        var json = JsonConvert.SerializeObject(postBody);

        var httpResponse = await new HttpClient().PostAsync(
            "https://accounts.zoho.eu/oauth/v2/token",
            new StringContent(json, Encoding.UTF8, "application/json")
        );

        if (httpResponse.IsSuccessStatusCode)
        {
            TokenResponse? responseData =
                JsonConvert.DeserializeObject<TokenResponse>(await httpResponse.Content.ReadAsStringAsync());
            
            // Console.WriteLine(responseData?.AccessToken);
            token = responseData?.AccessToken;
        }*/

        request.Headers.Add("Authorization", "Zoho-oauthtoken 1000.1f9042e6293e6a689be9d595f5a2364c.c03188331f3a2a46c97c0505b1c0b6fb");  // Add whatever headers you want here

        return await base.SendAsync(request, cancellationToken);
    }
}