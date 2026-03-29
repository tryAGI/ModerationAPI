
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationObjectResponseVariant1Field
    {
        /// <summary>
        /// The key of the field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Whether the field was flagged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Flagged { get; set; }

        /// <summary>
        /// The models that flagged the field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FlaggedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Field" /> class.
        /// </summary>
        /// <param name="key">
        /// The key of the field
        /// </param>
        /// <param name="flagged">
        /// Whether the field was flagged
        /// </param>
        /// <param name="flaggedBy">
        /// The models that flagged the field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationObjectResponseVariant1Field(
            string key,
            bool flagged,
            global::System.Collections.Generic.IList<string> flaggedBy)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Flagged = flagged;
            this.FlaggedBy = flaggedBy ?? throw new global::System.ArgumentNullException(nameof(flaggedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Field" /> class.
        /// </summary>
        public ModerationObjectResponseVariant1Field()
        {
        }
    }
}