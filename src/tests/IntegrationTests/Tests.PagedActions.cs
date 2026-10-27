using System.Net;
using System.Text;

namespace ModerationAPI.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task PagedActionsRetainClientAndToolContracts()
    {
        using var handler = new PagedActionsHandler();
        using var http = new HttpClient(handler);
        using var client = new ModerationAPIClient("offline", httpClient: http);
        var page = await client.Actions.ActionsListAsync();
        page.Data.Should().BeEmpty();
        page.Pagination.Page.Should().Be(1);
        page.Pagination.HasMore.Should().BeFalse();
        var result = await client.AsListActionsTool().InvokeAsync();
        result.Should().NotBeNull();
        handler.Requests.Should().Be(2);
    }

    private sealed class PagedActionsHandler : HttpMessageHandler
    {
        public int Requests { get; private set; }
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.RequestUri!.AbsolutePath.Should().Be("/v1/actions");
            request.Method.Should().Be(HttpMethod.Get);
            request.Headers.Authorization!.Scheme.Should().Be("Bearer");
            Requests++;
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("""{"data":[],"pagination":{"page":1,"pageSize":20,"total":0,"totalPages":0,"hasMore":false}}""", Encoding.UTF8, "application/json"),
            });
        }
    }
}
