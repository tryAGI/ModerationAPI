
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Brand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation2" /> class.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="method"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation2(
            string brand,
            global::ModerationAPI.NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonationMethod method)
        {
            this.Brand = brand ?? throw new global::System.ArgumentNullException(nameof(brand));
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation2" /> class.
        /// </summary>
        public NewModerateModerateResponsePolicieEntityMatcherOutputMatcheSignalsBrandImpersonation2()
        {
        }

    }
}