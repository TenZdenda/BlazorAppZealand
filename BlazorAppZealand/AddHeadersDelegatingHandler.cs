namespace BlazorAppZealand;

public class AddHeadersDelegatingHandler : DelegatingHandler
{
    public AddHeadersDelegatingHandler() : base(new HttpClientHandler())
    {
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("Authorization", "Zoho-oauthtoken 1000.c2c36e2d0b78661cca38beaf32d40ed9.e288caad5dcb0d3d6e2e2393bfcb4d3f");  // Add whatever headers you want here

        return base.SendAsync(request, cancellationToken);
    }
}