
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieUnicodeSpoofingSignals2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flag")]
        public bool? Flag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUnicodeSpoofingSignals2" /> class.
        /// </summary>
        /// <param name="flag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPolicieUnicodeSpoofingSignals2(
            bool? flag)
        {
            this.Flag = flag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUnicodeSpoofingSignals2" /> class.
        /// </summary>
        public NewModerateModerateRequestPolicieUnicodeSpoofingSignals2()
        {
        }

    }
}