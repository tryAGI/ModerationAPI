
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieUnicodeSpoofing
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
        /// <default>"unicode_spoofing"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "unicode_spoofing";

        /// <summary>
        /// Per-signal flag toggles. Omitted spoofing signals are enabled; encoding_damage defaults to off because decode damage (U+FFFD) marks a broken pipeline, not an attack. A disabled signal is still detected and reported as a label, but does not by itself flag the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signals")]
        public global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2>? Signals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUnicodeSpoofing" /> class.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="threshold"></param>
        /// <param name="signals">
        /// Per-signal flag toggles. Omitted spoofing signals are enabled; encoding_damage defaults to off because decode damage (U+FFFD) marks a broken pipeline, not an attack. A disabled signal is still detected and reported as a label, but does not by itself flag the policy.
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPolicieUnicodeSpoofing(
            bool flag,
            double? threshold,
            global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUnicodeSpoofingSignals2>? signals,
            string id = "unicode_spoofing")
        {
            this.Flag = flag;
            this.Threshold = threshold;
            this.Id = id;
            this.Signals = signals;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUnicodeSpoofing" /> class.
        /// </summary>
        public NewModerateModerateRequestPolicieUnicodeSpoofing()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NewModerateModerateRequestPolicieUnicodeSpoofing"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NewModerateModerateRequestPolicieUnicodeSpoofing FromFlag(bool flag)
        {
            return new NewModerateModerateRequestPolicieUnicodeSpoofing
            {
                Flag = flag,
            };
        }

    }
}