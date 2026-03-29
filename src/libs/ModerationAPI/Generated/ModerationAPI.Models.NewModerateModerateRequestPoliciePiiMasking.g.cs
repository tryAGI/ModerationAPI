
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateRequestPoliciePiiMasking
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"pii"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "pii";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2> Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPoliciePiiMasking" /> class.
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateRequestPoliciePiiMasking(
            global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.NewModerateModerateRequestPoliciePiiMaskingEntities2> entities,
            string id = "pii")
        {
            this.Id = id;
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateRequestPoliciePiiMasking" /> class.
        /// </summary>
        public NewModerateModerateRequestPoliciePiiMasking()
        {
        }
    }
}