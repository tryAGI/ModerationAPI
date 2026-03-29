
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsExecuteDeprecatedResponse
    {
        /// <summary>
        /// Action executed successfully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The ID of the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionId { get; set; }

        /// <summary>
        /// The IDs of the content items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsExecuteDeprecatedResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Action executed successfully.
        /// </param>
        /// <param name="actionId">
        /// The ID of the action.
        /// </param>
        /// <param name="ids">
        /// The IDs of the content items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsExecuteDeprecatedResponse(
            bool success,
            string actionId,
            global::System.Collections.Generic.IList<string> ids)
        {
            this.Success = success;
            this.ActionId = actionId ?? throw new global::System.ArgumentNullException(nameof(actionId));
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsExecuteDeprecatedResponse" /> class.
        /// </summary>
        public ActionsExecuteDeprecatedResponse()
        {
        }
    }
}