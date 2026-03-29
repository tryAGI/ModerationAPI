/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace ModerationAPI.IntegrationTests;

public partial class Tests
{
    //// ModerationAPI provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios. This enables AI agents to moderate content
    //// as part of their conversation flow.

    [TestMethod]
    public void Example_CreateTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create tools for text moderation, image moderation, queue stats, and listing actions.
        var moderateTextTool = client.AsModerateTextTool();
        var moderateImageTool = client.AsModerateImageTool();
        var getQueueStatsTool = client.AsGetQueueStatsTool();
        var listActionsTool = client.AsListActionsTool();

        Assert.AreEqual("ModerationAPI_ModerateText", moderateTextTool.Name);
        Assert.AreEqual("ModerationAPI_ModerateImage", moderateImageTool.Name);
        Assert.AreEqual("ModerationAPI_GetQueueStats", getQueueStatsTool.Name);
        Assert.AreEqual("ModerationAPI_ListActions", listActionsTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { moderateTextTool, moderateImageTool, getQueueStatsTool, listActionsTool };
        Assert.AreEqual(4, tools.Length);
    }
}
