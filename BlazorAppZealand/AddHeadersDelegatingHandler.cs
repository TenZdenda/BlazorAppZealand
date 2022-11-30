namespace BlazorAppZealand;

public class AddHeadersDelegatingHandler : DelegatingHandler
{
    public AddHeadersDelegatingHandler() : base(new HttpClientHandler())
    {
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("Authorization", "Zoho-oauthtoken 1000.8f1e7056eeb418e56516ad6fb4f792c8.f6f76320b57965f175f7c8bd6d1fe59b");  // Add whatever headers you want here

        return base.SendAsync(request, cancellationToken);
    }
}