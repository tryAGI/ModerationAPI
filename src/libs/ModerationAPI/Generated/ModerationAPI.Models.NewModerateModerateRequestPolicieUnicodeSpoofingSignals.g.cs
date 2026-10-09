
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Per-signal flag toggles. Omitted spoofing signals are enabled; encoding_damage defaults to off because decode damage (U+FFFD) marks a broken pipeline, not an attack. A disabled signal is still detected and reported as a label, but does not by itself flag the policy.
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieUnicodeSpoofingSignals
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}