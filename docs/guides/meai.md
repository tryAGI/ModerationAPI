# Microsoft.Extensions.AI Integration

ModerationAPI provides `AIFunction` tools that can be used with any `IChatClient` for function/tool calling scenarios. This enables AI agents to moderate content as part of their conversation flow.

## Available Tools

| Tool | Description |
|------|-------------|
| `AsModerateTextTool()` | Moderate text content for toxicity, profanity, PII, spam, violence, hate speech, self-harm, sexual content, and more |
| `AsModerateImageTool()` | Moderate an image by URL for NSFW content, violence, hate symbols, and more |
| `AsGetQueueStatsTool()` | Get detailed statistics about a moderation review queue |
| `AsListActionsTool()` | List all available moderation actions for the organization |

## Usage

```csharp
using ModerationAPI;

var client = new ModerationAPIClient(apiKey);

// Create tools
var moderateTextTool = client.AsModerateTextTool();
var moderateImageTool = client.AsModerateImageTool();
var getQueueStatsTool = client.AsGetQueueStatsTool();
var listActionsTool = client.AsListActionsTool();

// Use with any IChatClient
var tools = new[] { moderateTextTool, moderateImageTool, getQueueStatsTool, listActionsTool };
```

## Tool Details

### AsModerateTextTool

Submits text content for moderation analysis. Returns:
- Whether the content was flagged
- Flag probability and severity score
- Recommended action (allow, review, or reject)
- Reason codes for the recommendation

### AsModerateImageTool

Submits an image URL for moderation analysis. Returns the same evaluation structure as text moderation.

### AsGetQueueStatsTool

Retrieves statistics for a moderation review queue including review times, action counts, top reviewers, and trends.

### AsListActionsTool

Lists all configured moderation actions (e.g., ban, mute, warn, custom actions) for the authenticated organization.
