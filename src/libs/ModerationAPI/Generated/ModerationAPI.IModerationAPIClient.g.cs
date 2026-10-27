
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Moderate text, images, video and audio in real time, manage authors, review queues and actions, and receive webhooks.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IModerationAPIClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::ModerationAPI.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::ModerationAPI.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// The account that owns the API key.
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        /// Moderation actions reviewers and rules can take.
        /// </summary>
        public ActionsClient Actions { get; }

        /// <summary>
        ///
        /// </summary>
        public AnalyticsClient Analytics { get; }

        /// <summary>
        ///
        /// </summary>
        public AuthorClient Author { get; }

        /// <summary>
        /// Channels in a project. Needs an organization key.
        /// </summary>
        public ChannelsClient Channels { get; }

        /// <summary>
        ///
        /// </summary>
        public FeedbackClient Feedback { get; }

        /// <summary>
        /// Projects in the organization. Needs an organization key.
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        ///
        /// </summary>
        public ProjectsApiKeysClient ProjectsApiKeys { get; }

        /// <summary>
        ///
        /// </summary>
        public QueueClient Queue { get; }

        /// <summary>
        ///
        /// </summary>
        public QueueItemsClient QueueItems { get; }

        /// <summary>
        ///
        /// </summary>
        public ReviewQueuesClient ReviewQueues { get; }

        /// <summary>
        /// Endpoints that receive events, and the events they receive.
        /// </summary>
        public WebhooksClient Webhooks { get; }

        /// <summary>
        ///
        /// </summary>
        public WordlistClient Wordlist { get; }

    }
}