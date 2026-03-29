
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Average sentiment score of content (-1 to 1). Requires a sentiment model in your project.
    /// </summary>
    public sealed partial class AuthorOpenGetAuthorDetailsResponseMetricsAverageSentiment
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}