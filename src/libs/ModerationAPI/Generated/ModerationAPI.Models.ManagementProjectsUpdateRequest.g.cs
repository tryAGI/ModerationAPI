
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ManagementProjectsUpdateRequest
    {
        /// <summary>
        /// The project's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The project's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The website or app the project moderates content for. Setting it on a project without context writes one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// What the platform is and who uses it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// `ACTIVE` flags content. `DRY_RUN` evaluates without flagging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalFlaggingMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ManagementProjectsUpdateRequestGlobalFlaggingModeJsonConverter))]
        public global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode? GlobalFlaggingMode { get; set; }

        /// <summary>
        /// Whether moderated content is stored and shown in the dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableRequestLogging")]
        public bool? EnableRequestLogging { get; set; }

        /// <summary>
        /// Whether review queue decisions are recorded in the casebook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("casebookEnabled")]
        public bool? CasebookEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The project's name.
        /// </param>
        /// <param name="description">
        /// The project's description.
        /// </param>
        /// <param name="domain">
        /// The website or app the project moderates content for. Setting it on a project without context writes one.
        /// </param>
        /// <param name="context">
        /// What the platform is and who uses it.
        /// </param>
        /// <param name="globalFlaggingMode">
        /// `ACTIVE` flags content. `DRY_RUN` evaluates without flagging.
        /// </param>
        /// <param name="enableRequestLogging">
        /// Whether moderated content is stored and shown in the dashboard.
        /// </param>
        /// <param name="casebookEnabled">
        /// Whether review queue decisions are recorded in the casebook.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagementProjectsUpdateRequest(
            string? name,
            string? description,
            string? domain,
            string? context,
            global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode? globalFlaggingMode,
            bool? enableRequestLogging,
            bool? casebookEnabled)
        {
            this.Name = name;
            this.Description = description;
            this.Domain = domain;
            this.Context = context;
            this.GlobalFlaggingMode = globalFlaggingMode;
            this.EnableRequestLogging = enableRequestLogging;
            this.CasebookEnabled = casebookEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementProjectsUpdateRequest" /> class.
        /// </summary>
        public ManagementProjectsUpdateRequest()
        {
        }

    }
}