
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetChannelPoliciesResponse
    {
        /// <summary>
        /// Every policy the channel can use, on and off. Policies that are off show their default settings. Guidelines and wordlists have their own endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ChannelPolicy> Policies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelPoliciesResponse" /> class.
        /// </summary>
        /// <param name="policies">
        /// Every policy the channel can use, on and off. Policies that are off show their default settings. Guidelines and wordlists have their own endpoints.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChannelPoliciesResponse(
            global::System.Collections.Generic.IList<global::ModerationAPI.ChannelPolicy> policies)
        {
            this.Policies = policies ?? throw new global::System.ArgumentNullException(nameof(policies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelPoliciesResponse" /> class.
        /// </summary>
        public GetChannelPoliciesResponse()
        {
        }

    }
}