
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Settings of this policy type, merged into the current settings. `pii_masking` and `url_masking`: `entities`, for example `{ "email": { "enable": true, "shouldMask": true, "mask": "[EMAIL]" } }`. `url_risk`: `allowlistWordlistIds`, `blocklistWordlistIds`, `flagLinkShorteners`. `unicode_spoofing`: `signals`. Get channel policies shows the current settings of each policy.
    /// </summary>
    public sealed partial class UpdateChannelPoliciesRequestPolicieSettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}