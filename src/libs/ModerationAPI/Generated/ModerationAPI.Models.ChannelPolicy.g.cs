
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelPolicy
    {
        /// <summary>
        /// Names the policy in an update. The policy ID, or `custom_model:&lt;id&gt;` and `ai_agent:&lt;id&gt;` for models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The policy ID, for example `toxicity`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// `classifier` scores content and can flag it. `insight` only reports (sentiment, language, tone). `entity` finds and masks entities (PII, URLs). `custom_model` and `ai_agent` are models made for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ChannelPolicyTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ChannelPolicyType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether the channel runs the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether the channel can turn the policy on. See `unavailableReason`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Available { get; set; }

        /// <summary>
        /// Why the channel cannot turn the policy on, or null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unavailableReason")]
        public string? UnavailableReason { get; set; }

        /// <summary>
        /// Whether the policy flags content. When false, the policy only scores it. Null for insights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        public bool? Flag { get; set; }

        /// <summary>
        /// The score (0 to 1) at which the policy flags. Null uses the model default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Settings of this policy type, for example `entities` for PII masking or `allowlistWordlistIds` for URL risk. Empty for most policies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Settings { get; set; }

        /// <summary>
        /// For a legacy policy: the policy that replaces it. Move to it with Upgrade a channel policy. Null for current policies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upgradeTo")]
        public string? UpgradeTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelPolicy" /> class.
        /// </summary>
        /// <param name="key">
        /// Names the policy in an update. The policy ID, or `custom_model:&lt;id&gt;` and `ai_agent:&lt;id&gt;` for models.
        /// </param>
        /// <param name="id">
        /// The policy ID, for example `toxicity`.
        /// </param>
        /// <param name="type">
        /// `classifier` scores content and can flag it. `insight` only reports (sentiment, language, tone). `entity` finds and masks entities (PII, URLs). `custom_model` and `ai_agent` are models made for the organization.
        /// </param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="enabled">
        /// Whether the channel runs the policy.
        /// </param>
        /// <param name="available">
        /// Whether the channel can turn the policy on. See `unavailableReason`.
        /// </param>
        /// <param name="settings">
        /// Settings of this policy type, for example `entities` for PII masking or `allowlistWordlistIds` for URL risk. Empty for most policies.
        /// </param>
        /// <param name="unavailableReason">
        /// Why the channel cannot turn the policy on, or null.
        /// </param>
        /// <param name="flag">
        /// Whether the policy flags content. When false, the policy only scores it. Null for insights.
        /// </param>
        /// <param name="threshold">
        /// The score (0 to 1) at which the policy flags. Null uses the model default.
        /// </param>
        /// <param name="upgradeTo">
        /// For a legacy policy: the policy that replaces it. Move to it with Upgrade a channel policy. Null for current policies.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelPolicy(
            string key,
            string id,
            global::ModerationAPI.ChannelPolicyType type,
            string title,
            string description,
            bool enabled,
            bool available,
            object settings,
            string? unavailableReason,
            bool? flag,
            double? threshold,
            string? upgradeTo)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Enabled = enabled;
            this.Available = available;
            this.UnavailableReason = unavailableReason;
            this.Flag = flag;
            this.Threshold = threshold;
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.UpgradeTo = upgradeTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelPolicy" /> class.
        /// </summary>
        public ChannelPolicy()
        {
        }

    }
}