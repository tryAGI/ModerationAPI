
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateChannelPoliciesRequest
    {
        /// <summary>
        /// The policies to change. Policies you leave out keep their state. All changes are saved together, or none when one fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelPoliciesRequestPolicie> Policies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelPoliciesRequest" /> class.
        /// </summary>
        /// <param name="policies">
        /// The policies to change. Policies you leave out keep their state. All changes are saved together, or none when one fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChannelPoliciesRequest(
            global::System.Collections.Generic.IList<global::ModerationAPI.UpdateChannelPoliciesRequestPolicie> policies)
        {
            this.Policies = policies ?? throw new global::System.ArgumentNullException(nameof(policies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChannelPoliciesRequest" /> class.
        /// </summary>
        public UpdateChannelPoliciesRequest()
        {
        }

    }
}