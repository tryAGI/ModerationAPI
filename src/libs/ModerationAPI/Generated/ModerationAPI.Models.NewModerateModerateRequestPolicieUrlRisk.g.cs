
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieUrlRisk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"url_risk"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "url_risk";

        /// <summary>
        /// IDs of wordlists whose entries are treated as allowed URL domains. Matches short-circuit the risk model and are never flagged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowlistWordlistIds")]
        public global::System.Collections.Generic.IList<string>? AllowlistWordlistIds { get; set; }

        /// <summary>
        /// IDs of wordlists whose entries are treated as blocked URL domains. Matches short-circuit the risk model and are always flagged. Blocklists take precedence over allowlists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocklistWordlistIds")]
        public global::System.Collections.Generic.IList<string>? BlocklistWordlistIds { get; set; }

        /// <summary>
        /// When true, any URL detected as a free link shortener (bit.ly, t.co, tinyurl, etc.) is always flagged regardless of risk score. Allowlist matches still win.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagLinkShorteners")]
        public bool? FlagLinkShorteners { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUrlRisk" /> class.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="threshold"></param>
        /// <param name="allowlistWordlistIds">
        /// IDs of wordlists whose entries are treated as allowed URL domains. Matches short-circuit the risk model and are never flagged.
        /// </param>
        /// <param name="blocklistWordlistIds">
        /// IDs of wordlists whose entries are treated as blocked URL domains. Matches short-circuit the risk model and are always flagged. Blocklists take precedence over allowlists.
        /// </param>
        /// <param name="flagLinkShorteners">
        /// When true, any URL detected as a free link shortener (bit.ly, t.co, tinyurl, etc.) is always flagged regardless of risk score. Allowlist matches still win.
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPolicieUrlRisk(
            bool flag,
            double? threshold,
            global::System.Collections.Generic.IList<string>? allowlistWordlistIds,
            global::System.Collections.Generic.IList<string>? blocklistWordlistIds,
            bool? flagLinkShorteners,
            string id = "url_risk")
        {
            this.Flag = flag;
            this.Threshold = threshold;
            this.Id = id;
            this.AllowlistWordlistIds = allowlistWordlistIds;
            this.BlocklistWordlistIds = blocklistWordlistIds;
            this.FlagLinkShorteners = flagLinkShorteners;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUrlRisk" /> class.
        /// </summary>
        public NewModerateModerateRequestPolicieUrlRisk()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NewModerateModerateRequestPolicieUrlRisk"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NewModerateModerateRequestPolicieUrlRisk FromFlag(bool flag)
        {
            return new NewModerateModerateRequestPolicieUrlRisk
            {
                Flag = flag,
            };
        }

    }
}