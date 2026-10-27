
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsAutomationResponseRule
    {
        /// <summary>
        /// The rule name. "Other rules" holds all rules after the largest ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Flagged requests that this rule settled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsAutomationResponseRule" /> class.
        /// </summary>
        /// <param name="name">
        /// The rule name. "Other rules" holds all rules after the largest ones.
        /// </param>
        /// <param name="count">
        /// Flagged requests that this rule settled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsAutomationResponseRule(
            string name,
            int count)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsAutomationResponseRule" /> class.
        /// </summary>
        public GetAnalyticsAutomationResponseRule()
        {
        }

    }
}