
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Per-signal flag toggles. Omitted spoofing signals are enabled; encoding_damage defaults to off because decode damage (U+FFFD) marks a broken pipeline, not an attack, and hidden_lookalike and leetspeak default to off because they are opt-in. A disabled signal is still detected and reported as a label, but does not by itself flag the policy. Lookalike words are only spelled out in the cleaned text when their signal is enabled.
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