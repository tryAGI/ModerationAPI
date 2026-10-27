
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieAlcohol
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
        /// <default>"alcohol"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "alcohol";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieAlcohol" /> class.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="threshold"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPolicieAlcohol(
            bool flag,
            double? threshold,
            string id = "alcohol")
        {
            this.Flag = flag;
            this.Threshold = threshold;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieAlcohol" /> class.
        /// </summary>
        public NewModerateModerateRequestPolicieAlcohol()
        {
        }

        /// <summary>
        /// Creates a new <see cref="NewModerateModerateRequestPolicieAlcohol"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static NewModerateModerateRequestPolicieAlcohol FromFlag(bool flag)
        {
            return new NewModerateModerateRequestPolicieAlcohol
            {
                Flag = flag,
            };
        }

    }
}