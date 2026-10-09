
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementProjectsDeleteResponse
    {
        /// <summary>
        /// Whether the project was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The ID of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectsDeleteResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the project was deleted.
        /// </param>
        /// <param name="id">
        /// The ID of the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementProjectsDeleteResponse(
            bool deleted,
            string id)
        {
            this.Deleted = deleted;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectsDeleteResponse" /> class.
        /// </summary>
        public ManagementProjectsDeleteResponse()
        {
        }

    }
}