namespace BlazorAppZealand;

public class AddHeadersDelegatingHandler : DelegatingHandler
{
    public AddHeadersDelegatingHandler() : base(new HttpClientHandler())
    {
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("Authorization", "Zoho-oauthtoken 1000.d53d4bb158f799b2cb81726d912a46a5.0bde8c56fae9ec9ac69fee032554b74a");  // Add whatever headers you want here

        return base.SendAsync(request, cancellationToken);
    }
}