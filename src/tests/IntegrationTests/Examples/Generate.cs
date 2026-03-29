/* order: 10, title: Text Moderation, slug: text-moderation */

namespace ModerationAPI.IntegrationTests;

public partial class Tests
{
    //// Submit text content for moderation analysis. The API evaluates the text
    //// against configured policies (toxicity, profanity, PII, spam, etc.) and
    //// returns a recommendation (allow, review, or reject).

    [TestMethod]
    public async Task Example_ModerateText()
    {
        using var client = GetAuthenticatedClient();

        //// Create a text moderation request.
        OneOf<NewModerateModerateRequestContentContentLeafText, NewModerateModerateRequestContentContentLeafImage, NewModerateModerateRequestContentContentLeafVideo, NewModerateModerateRequestContentContentLeafAudio>?
            textContent = new NewModerateModerateRequestContentContentLeafText("Hello, this is a friendly message.");

        var response = await client.NewModerateModerateAsync(
            request: new NewModerateModerateRequest
            {
                Content = textContent,
                DoNotStore = true,
            });

        //// Check the evaluation result.
        Assert.IsNotNull(response);
        Assert.IsNotNull(response.Evaluation);
        Assert.IsNotNull(response.Recommendation);

        //// The evaluation includes whether the content was flagged, the flag probability,
        //// and a severity score.
        Console.WriteLine($"Flagged: {response.Evaluation.Flagged}");
        Console.WriteLine($"Flag Probability: {response.Evaluation.FlagProbability}");
        Console.WriteLine($"Severity Score: {response.Evaluation.SeverityScore}");
        Console.WriteLine($"Recommended Action: {response.Recommendation.Action}");
    }
}
