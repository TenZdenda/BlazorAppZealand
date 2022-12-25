namespace BlazorAppZealand;

public class AddHeadersDelegatingHandler : DelegatingHandler
{
    public AddHeadersDelegatingHandler() : base(new HttpClientHandler())
    {
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("Authorization", "Zoho-oauthtoken 1000.8caac6e6c49659267d14fdff8f2287e6.26d927fa3fdbdb8f7e1d3eea436789eb");  // Add whatever headers you want here

        return base.SendAsync(request, cancellationToken);
    }
}