namespace BlazorAppZealand;

public class AddHeadersDelegatingHandler : DelegatingHandler
{
    public AddHeadersDelegatingHandler() : base(new HttpClientHandler())
    {
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("Authorization", "Zoho-oauthtoken 1000.fe488d8eaaa171b15799e3b8166b84f0.915598d5fcaaada1668fad61a3844ad4");  // Add whatever headers you want here

        return base.SendAsync(request, cancellationToken);
    }
}