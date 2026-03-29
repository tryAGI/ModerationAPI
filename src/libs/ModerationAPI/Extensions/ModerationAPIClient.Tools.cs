#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace ModerationAPI;

public static class ModerationAPIClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that moderates text content for toxicity, profanity, PII, spam, and more.
    /// </summary>
    public static AIFunction AsModerateTextTool(this ModerationAPIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The text content to moderate for toxicity, profanity, PII, spam, violence, and other policy violations")] string text,
                   CancellationToken cancellationToken) =>
            {
                OneOf<NewModerateModerateRequestContentContentLeafText, NewModerateModerateRequestContentContentLeafImage, NewModerateModerateRequestContentContentLeafVideo, NewModerateModerateRequestContentContentLeafAudio>?
                    innerContent = new NewModerateModerateRequestContentContentLeafText(text);

                var response = await client.NewModerateModerateAsync(
                    request: new NewModerateModerateRequest
                    {
                        Content = innerContent,
                        DoNotStore = true,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Evaluation.Flagged,
                    response.Evaluation.FlagProbability,
                    response.Evaluation.SeverityScore,
                    RecommendedAction = response.Recommendation.Action.ToString(),
                    ReasonCodes = response.Recommendation.ReasonCodes
                        .Select(r => r.ToString()).ToArray(),
                };
            },
            name: "ModerationAPI_ModerateText",
            description: "Moderate text content for policy violations including toxicity, profanity, PII, spam, violence, hate speech, self-harm, sexual content, and more. Returns whether the content is flagged, severity score, and recommended action (allow/review/reject).");
    }

    /// <summary>
    /// Creates an AIFunction tool that moderates image content for NSFW, violence, and other violations.
    /// </summary>
    public static AIFunction AsModerateImageTool(this ModerationAPIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The public URL of the image to moderate for NSFW, violence, and other policy violations")] string imageUrl,
                   CancellationToken cancellationToken) =>
            {
                OneOf<NewModerateModerateRequestContentContentLeafText, NewModerateModerateRequestContentContentLeafImage, NewModerateModerateRequestContentContentLeafVideo, NewModerateModerateRequestContentContentLeafAudio>?
                    innerContent = new NewModerateModerateRequestContentContentLeafImage(imageUrl);

                var response = await client.NewModerateModerateAsync(
                    request: new NewModerateModerateRequest
                    {
                        Content = innerContent,
                        DoNotStore = true,
                    },
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Evaluation.Flagged,
                    response.Evaluation.FlagProbability,
                    response.Evaluation.SeverityScore,
                    RecommendedAction = response.Recommendation.Action.ToString(),
                    ReasonCodes = response.Recommendation.ReasonCodes
                        .Select(r => r.ToString()).ToArray(),
                };
            },
            name: "ModerationAPI_ModerateImage",
            description: "Moderate an image by URL for policy violations including NSFW content, violence, hate symbols, and more. Returns whether the image is flagged, severity score, and recommended action (allow/review/reject).");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the details and statistics of a review queue.
    /// </summary>
    public static AIFunction AsGetQueueStatsTool(this ModerationAPIClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The review queue ID to get statistics for")] string queueId,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.ReviewQueues.QueueViewOpenGetStatsAsync(
                    id: queueId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "ModerationAPI_GetQueueStats",
            description: "Get detailed statistics about a moderation review queue including review times, action counts, top reviewers, and trends.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists available moderation actions.
    /// </summary>
    public static AIFunction AsListActionsTool(this ModerationAPIClient client)
    {
        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Actions.ActionsListAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "ModerationAPI_ListActions",
            description: "List all available moderation actions for the authenticated organization, such as ban, mute, warn, or custom actions.");
    }
}
