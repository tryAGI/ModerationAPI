
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueViewOpenGetStatsResponseTopReviewerTopAction
    {
        /// <summary>
        /// Most used action by this reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionId { get; set; }

        /// <summary>
        /// Name of the most used action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionName { get; set; }

        /// <summary>
        /// Number of times this action was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTopReviewerTopAction" /> class.
        /// </summary>
        /// <param name="actionId">
        /// Most used action by this reviewer
        /// </param>
        /// <param name="actionName">
        /// Name of the most used action
        /// </param>
        /// <param name="count">
        /// Number of times this action was used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueViewOpenGetStatsResponseTopReviewerTopAction(
            string actionId,
            string actionName,
            double count)
        {
            this.ActionId = actionId ?? throw new global::System.ArgumentNullException(nameof(actionId));
            this.ActionName = actionName ?? throw new global::System.ArgumentNullException(nameof(actionName));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueViewOpenGetStatsResponseTopReviewerTopAction" /> class.
        /// </summary>
        public QueueViewOpenGetStatsResponseTopReviewerTopAction()
        {
        }
    }
}