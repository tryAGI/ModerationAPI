
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieLowQualityContent
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
        /// <default>"low_quality"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "low_quality";

        /// <summary>
        /// Flag content with fewer than this many words as low-effort. Defaults to 3. Set to disable by omitting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minWords")]
        public int? MinWords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieLowQualityContent" /> class.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="threshold"></param>
        /// <param name="minWords">
        /// Flag content with fewer than this many words as low-effort. Defaults to 3. Set to disable by omitting.
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPolicieLowQualityContent(
            bool flag,
            double? threshold,
            int? minWords,
            string id = "low_quality")
        {
            this.Flag = flag;
            this.Threshold = threshold;
            this.Id = id;
            this.MinWords = minWords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieLowQualityContent" /> class.
        /// </summary>
        public NewModerateModerateRequestPolicieLowQualityContent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NewModerateModerateRequestPolicieLowQualityContent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NewModerateModerateRequestPolicieLowQualityContent FromFlag(bool flag)
        {
            return new NewModerateModerateRequestPolicieLowQualityContent
            {
                Flag = flag,
            };
        }

    }
}