
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationVideoResponseVariant1AuthorTrustLevel
    {
        /// <summary>
        /// Author trust level (-1, 0, 1, 2, 3, or 4)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Level { get; set; }

        /// <summary>
        /// True if the trust level was set manually by a moderator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Manual { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationVideoResponseVariant1AuthorTrustLevel" /> class.
        /// </summary>
        /// <param name="level">
        /// Author trust level (-1, 0, 1, 2, 3, or 4)
        /// </param>
        /// <param name="manual">
        /// True if the trust level was set manually by a moderator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationVideoResponseVariant1AuthorTrustLevel(
            double level,
            bool manual)
        {
            this.Level = level;
            this.Manual = manual;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationVideoResponseVariant1AuthorTrustLevel" /> class.
        /// </summary>
        public ModerationVideoResponseVariant1AuthorTrustLevel()
        {
        }
    }
}