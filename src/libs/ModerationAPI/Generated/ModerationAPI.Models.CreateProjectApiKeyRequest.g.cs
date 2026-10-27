
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectApiKeyRequest
    {
        /// <summary>
        /// A name for the key, shown on the API keys page of the dashboard. Name it after where the key is used, for example the app or the computer.<br/>
        /// Default Value: API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectApiKeyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A name for the key, shown on the API keys page of the dashboard. Name it after where the key is used, for example the app or the computer.<br/>
        /// Default Value: API key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectApiKeyRequest(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectApiKeyRequest" /> class.
        /// </summary>
        public CreateProjectApiKeyRequest()
        {
        }

    }
}