# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The ModerationAPI SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to multi-modal content moderation for text and images, review queue statistics, and moderation action management.

## Installation

```bash
dotnet add package ModerationAPI
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsModerateTextTool()` | `ModerationAPI_ModerateText` | Moderate text for toxicity, profanity, PII, spam, violence, hate speech, and more |
| `AsModerateImageTool()` | `ModerationAPI_ModerateImage` | Moderate an image by URL for NSFW, violence, hate symbols, and more |
| `AsGetQueueStatsTool()` | `ModerationAPI_GetQueueStats` | Get review queue statistics including review times and action counts |
| `AsListActionsTool()` | `ModerationAPI_ListActions` | List all available moderation actions (ban, mute, warn, etc.) |

## Usage

```csharp
using ModerationAPI;
using Microsoft.Extensions.AI;

var moderationClient = new ModerationAPIClient(
    apiKey: Environment.GetEnvironmentVariable("MODERATIONAPI_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        moderationClient.AsModerateTextTool(),
        moderationClient.AsModerateImageTool(),
        moderationClient.AsGetQueueStatsTool(),
        moderationClient.AsListActionsTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Check this text for policy violations: 'Hello, this is a test message.'"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
