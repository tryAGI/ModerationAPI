
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicQueueItemLabelsVariant1ItemMatcheSignals
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand_impersonation")]
        public global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation2? BrandImpersonation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_suspicious_characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasSuspiciousCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_link_shortener")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLinkShortener { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain_age_days")]
        public double? DomainAgeDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_email_setup")]
        public bool? HasEmailSetup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_count")]
        public double? RedirectCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_url")]
        public string? FinalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_protection")]
        public bool? BotProtection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_reported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsReported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemLabelsVariant1ItemMatcheSignals" /> class.
        /// </summary>
        /// <param name="hasSuspiciousCharacters"></param>
        /// <param name="isLinkShortener"></param>
        /// <param name="isReported"></param>
        /// <param name="brandImpersonation"></param>
        /// <param name="domainAgeDays"></param>
        /// <param name="hasEmailSetup"></param>
        /// <param name="redirectCount"></param>
        /// <param name="finalUrl"></param>
        /// <param name="botProtection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicQueueItemLabelsVariant1ItemMatcheSignals(
            bool hasSuspiciousCharacters,
            bool isLinkShortener,
            bool isReported,
            global::ModerationAPI.PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation2? brandImpersonation,
            double? domainAgeDays,
            bool? hasEmailSetup,
            double? redirectCount,
            string? finalUrl,
            bool? botProtection)
        {
            this.BrandImpersonation = brandImpersonation;
            this.HasSuspiciousCharacters = hasSuspiciousCharacters;
            this.IsLinkShortener = isLinkShortener;
            this.DomainAgeDays = domainAgeDays;
            this.HasEmailSetup = hasEmailSetup;
            this.RedirectCount = redirectCount;
            this.FinalUrl = finalUrl;
            this.BotProtection = botProtection;
            this.IsReported = isReported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemLabelsVariant1ItemMatcheSignals" /> class.
        /// </summary>
        public PublicQueueItemLabelsVariant1ItemMatcheSignals()
        {
        }

    }
}