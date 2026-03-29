
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The author of the content if your account has authors enabled. Requires you to send authorId when submitting content.
    /// </summary>
    public sealed partial class NewModerateModerateResponseAuthor
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}