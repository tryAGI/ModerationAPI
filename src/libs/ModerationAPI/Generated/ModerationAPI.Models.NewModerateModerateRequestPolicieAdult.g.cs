
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieAdult
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
        /// <default>"adult"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "adult";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieAdult" /> class.
        /// </summary>
        /// <param name="flag"></param>
        /// <param name="threshold"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPolicieAdult(
            bool flag,
            double? threshold,
            string id = "adult")
        {
            this.Flag = flag;
            this.Threshold = threshold;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieAdult" /> class.
        /// </summary>
        public NewModerateModerateRequestPolicieAdult()
        {
        }
    }
}