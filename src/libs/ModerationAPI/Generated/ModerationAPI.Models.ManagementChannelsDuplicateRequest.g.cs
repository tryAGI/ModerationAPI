
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementChannelsDuplicateRequest
    {
        /// <summary>
        /// Name of the copy. Defaults to the original name with "(copy)".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Key of the copy. Defaults to the original key with a timestamp. Must be unique in the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementChannelsDuplicateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the copy. Defaults to the original name with "(copy)".
        /// </param>
        /// <param name="key">
        /// Key of the copy. Defaults to the original key with a timestamp. Must be unique in the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementChannelsDuplicateRequest(
            string? name,
            string? key)
        {
            this.Name = name;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementChannelsDuplicateRequest" /> class.
        /// </summary>
        public ManagementChannelsDuplicateRequest()
        {
        }

    }
}