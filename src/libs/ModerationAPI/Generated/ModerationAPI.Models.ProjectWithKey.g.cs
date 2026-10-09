
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectWithKey
    {
        /// <summary>
        /// The ID of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The project's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The project's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The website or app the project moderates content for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// What the platform is and who uses it. AI moderation reads it to judge content in context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it, for testing a setup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalFlaggingMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ProjectWithKeyGlobalFlaggingModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode GlobalFlaggingMode { get; set; }

        /// <summary>
        /// Whether moderated content is stored and shown in the dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableRequestLogging")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnableRequestLogging { get; set; }

        /// <summary>
        /// Whether decisions made in the review queue are recorded in the project's casebook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("casebookEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CasebookEnabled { get; set; }

        /// <summary>
        /// When the project was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// When the project was last changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// A secret API key for the new project. Use it to moderate content in this project. It is also shown in the project's settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWithKey" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the project.
        /// </param>
        /// <param name="name">
        /// The project's name.
        /// </param>
        /// <param name="globalFlaggingMode">
        /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it, for testing a setup.
        /// </param>
        /// <param name="enableRequestLogging">
        /// Whether moderated content is stored and shown in the dashboard.
        /// </param>
        /// <param name="casebookEnabled">
        /// Whether decisions made in the review queue are recorded in the project's casebook.
        /// </param>
        /// <param name="createdAt">
        /// When the project was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the project was last changed.
        /// </param>
        /// <param name="secretKey">
        /// A secret API key for the new project. Use it to moderate content in this project. It is also shown in the project's settings.
        /// </param>
        /// <param name="description">
        /// The project's description.
        /// </param>
        /// <param name="domain">
        /// The website or app the project moderates content for.
        /// </param>
        /// <param name="context">
        /// What the platform is and who uses it. AI moderation reads it to judge content in context.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectWithKey(
            string id,
            string name,
            global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode globalFlaggingMode,
            bool enableRequestLogging,
            bool casebookEnabled,
            string createdAt,
            string updatedAt,
            string secretKey,
            string? description,
            string? domain,
            string? context)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Domain = domain;
            this.Context = context;
            this.GlobalFlaggingMode = globalFlaggingMode;
            this.EnableRequestLogging = enableRequestLogging;
            this.CasebookEnabled = casebookEnabled;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.SecretKey = secretKey ?? throw new global::System.ArgumentNullException(nameof(secretKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectWithKey" /> class.
        /// </summary>
        public ProjectWithKey()
        {
        }

    }
}