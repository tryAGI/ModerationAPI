
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateChannelPoliciesRequestPolicie
    {
        /// <summary>
        /// The `key` of the policy, from Get channel policies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// True turns the policy on. False turns it off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Whether the policy flags content. When false, the policy only scores it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        public bool? Flag { get; set; }

        /// <summary>
        /// The score (0 to 1) at which it flags. Null goes back to the model default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Settings of this policy type, merged into the current settings. `pii_masking` and `url_masking`: `entities`, for example `{ "email": { "enable": true, "shouldMask": true, "mask": "[EMAIL]" } }`. `url_risk`: `allowlistWordlistIds`, `blocklistWordlistIds`, `flagLinkShorteners`. `unicode_spoofing`: `signals`. Get channel policies shows the current settings of each policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelPoliciesRequestPolicie" /> class.
        /// </summary>
        /// <param name="key">
        /// The `key` of the policy, from Get channel policies.
        /// </param>
        /// <param name="enabled">
        /// True turns the policy on. False turns it off.
        /// </param>
        /// <param name="flag">
        /// Whether the policy flags content. When false, the policy only scores it.
        /// </param>
        /// <param name="threshold">
        /// The score (0 to 1) at which it flags. Null goes back to the model default.
        /// </param>
        /// <param name="settings">
        /// Settings of this policy type, merged into the current settings. `pii_masking` and `url_masking`: `entities`, for example `{ "email": { "enable": true, "shouldMask": true, "mask": "[EMAIL]" } }`. `url_risk`: `allowlistWordlistIds`, `blocklistWordlistIds`, `flagLinkShorteners`. `unicode_spoofing`: `signals`. Get channel policies shows the current settings of each policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelPoliciesRequestPolicie(
            string key,
            bool enabled,
            bool? flag,
            double? threshold,
            object? settings)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Enabled = enabled;
            this.Flag = flag;
            this.Threshold = threshold;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelPoliciesRequestPolicie" /> class.
        /// </summary>
        public UpdateChannelPoliciesRequestPolicie()
        {
        }

    }
}