
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsPoliciesResponsePolicie
    {
        /// <summary>
        /// The policy label, for example `toxicity`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Flagged requests with this label in the window. Repeats count each time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Flagged { get; set; }

        /// <summary>
        /// Flagged requests with this label in the window of equal length before.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousFlagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PreviousFlagged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsPoliciesResponsePolicie" /> class.
        /// </summary>
        /// <param name="label">
        /// The policy label, for example `toxicity`.
        /// </param>
        /// <param name="flagged">
        /// Flagged requests with this label in the window. Repeats count each time.
        /// </param>
        /// <param name="previousFlagged">
        /// Flagged requests with this label in the window of equal length before.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsPoliciesResponsePolicie(
            string label,
            int flagged,
            int previousFlagged)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Flagged = flagged;
            this.PreviousFlagged = previousFlagged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsPoliciesResponsePolicie" /> class.
        /// </summary>
        public GetAnalyticsPoliciesResponsePolicie()
        {
        }

    }
}