namespace ModerationAPI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ModerationAPIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MODERATIONAPI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MODERATIONAPI_API_KEY environment variable is not found.");

        var client = new ModerationAPIClient(apiKey);
        
        return client;
    }
}
