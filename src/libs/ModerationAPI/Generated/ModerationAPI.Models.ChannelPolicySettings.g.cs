
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Settings of this policy type, for example `entities` for PII masking or `allowlistWordlistIds` for URL risk. Empty for most policies.
    /// </summary>
    public sealed partial class ChannelPolicySettings
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}