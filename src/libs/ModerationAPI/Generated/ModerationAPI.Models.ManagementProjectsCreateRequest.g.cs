
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementProjectsCreateRequest
    {
        /// <summary>
        /// The project's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The website or app the project moderates content for. Used to write the context when none is given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// What the platform is and who uses it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// What you moderate, the problems you see and your guidelines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brief")]
        public string? Brief { get; set; }

        /// <summary>
        /// Whether children use the platform.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usedByMinors")]
        public bool? UsedByMinors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectsCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The project's name.
        /// </param>
        /// <param name="domain">
        /// The website or app the project moderates content for. Used to write the context when none is given.
        /// </param>
        /// <param name="context">
        /// What the platform is and who uses it.
        /// </param>
        /// <param name="brief">
        /// What you moderate, the problems you see and your guidelines.
        /// </param>
        /// <param name="usedByMinors">
        /// Whether children use the platform.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementProjectsCreateRequest(
            string name,
            string? domain,
            string? context,
            string? brief,
            bool? usedByMinors)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Domain = domain;
            this.Context = context;
            this.Brief = brief;
            this.UsedByMinors = usedByMinors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectsCreateRequest" /> class.
        /// </summary>
        public ManagementProjectsCreateRequest()
        {
        }

    }
}