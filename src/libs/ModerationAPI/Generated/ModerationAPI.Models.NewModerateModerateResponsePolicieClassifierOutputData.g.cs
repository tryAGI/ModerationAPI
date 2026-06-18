
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Optional structured data produced by the policy. For face detection: { count, faces: [{ confidence, gender, age }] }.
    /// </summary>
    public sealed partial class NewModerateModerateResponsePolicieClassifierOutputData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}