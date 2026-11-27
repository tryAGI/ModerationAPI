
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpgradeChannelPolicyResponse
    {
        /// <summary>
        /// The policy the channel runs now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Successor { get; set; }

        /// <summary>
        /// How many of the channel's rules now read the new policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rulesUpdated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RulesUpdated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeChannelPolicyResponse" /> class.
        /// </summary>
        /// <param name="successor">
        /// The policy the channel runs now.
        /// </param>
        /// <param name="rulesUpdated">
        /// How many of the channel's rules now read the new policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpgradeChannelPolicyResponse(
            string successor,
            int rulesUpdated)
        {
            this.Successor = successor ?? throw new global::System.ArgumentNullException(nameof(successor));
            this.RulesUpdated = rulesUpdated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeChannelPolicyResponse" /> class.
        /// </summary>
        public UpgradeChannelPolicyResponse()
        {
        }

    }
}