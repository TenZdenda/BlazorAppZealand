namespace BlazorAppZealand;

public class AddHeadersDelegatingHandler : DelegatingHandler
{
    public AddHeadersDelegatingHandler() : base(new HttpClientHandler())
    {
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("Authorization", "Zoho-oauthtoken 1000.48510337e66ad3c25684393f0b6376da.8d24c1537f3e7218d418e8c4f927c7ce");  // Add whatever headers you want here

        return base.SendAsync(request, cancellationToken);
    }
}