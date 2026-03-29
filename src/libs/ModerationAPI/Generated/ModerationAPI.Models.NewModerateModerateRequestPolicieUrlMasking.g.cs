
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateRequestPolicieUrlMasking
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "url";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2> Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUrlMasking" /> class.
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPolicieUrlMasking(
            global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPolicieUrlMaskingEntities2> entities,
            string id = "url")
        {
            this.Id = id;
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPolicieUrlMasking" /> class.
        /// </summary>
        public NewModerateModerateRequestPolicieUrlMasking()
        {
        }
    }
}