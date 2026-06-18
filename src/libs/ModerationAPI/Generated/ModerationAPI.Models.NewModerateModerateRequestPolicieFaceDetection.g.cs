
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieFaceDetection
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
        /// <default>"face_detection"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "face_detection";

        /// <summary>
        /// Flag images that contain "at least" or "fewer than" the configured number of faces. Defaults to at_least.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateRequestPolicieFaceDetectionComparatorJsonConverter))]
        public global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator? Comparator { get; set; }

        /// <summary>
        /// Number of faces the comparator applies to. Defaults to 1, so the default rule flags any image containing a face.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieFaceDetection" /> class.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="threshold"></param>
        /// <param name="comparator">
        /// Flag images that contain "at least" or "fewer than" the configured number of faces. Defaults to at_least.
        /// </param>
        /// <param name="count">
        /// Number of faces the comparator applies to. Defaults to 1, so the default rule flags any image containing a face.
        /// </param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPolicieFaceDetection(
            bool flag,
            double? threshold,
            global::ModerationAPI.NewModerateModerateRequestPolicieFaceDetectionComparator? comparator,
            int? count,
            string id = "face_detection")
        {
            this.Flag = flag;
            this.Threshold = threshold;
            this.Id = id;
            this.Comparator = comparator;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieFaceDetection" /> class.
        /// </summary>
        public NewModerateModerateRequestPolicieFaceDetection()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NewModerateModerateRequestPolicieFaceDetection"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NewModerateModerateRequestPolicieFaceDetection FromFlag(bool flag)
        {
            return new NewModerateModerateRequestPolicieFaceDetection
            {
                Flag = flag,
            };
        }

    }
}