/* order: 30, title: List Actions, slug: list-actions */

namespace ModerationAPI.IntegrationTests;

public partial class Tests
{
    //// List all available moderation actions for your organization.
    //// Actions define what happens when content is flagged (e.g., ban, mute, warn).

    [TestMethod]
    public async Task Example_ListActions()
    {
        using var client = GetAuthenticatedClient();

        var actions = await client.Actions.ActionsListAsync();

        //// Each action has an ID, name, and configuration.
        Assert.IsNotNull(actions);

        foreach (var action in actions)
        {
            Console.WriteLine($"Action: {action.Name} (ID: {action.Id})");
        }
    }
}
