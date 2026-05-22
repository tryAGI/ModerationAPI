
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation2
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation2" /> class.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="method"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation2(
            string brand,
            string method)
        {
            this.Brand = brand ?? throw new global::System.ArgumentNullException(nameof(brand));
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation2" /> class.
        /// </summary>
        public PublicQueueItemLabelsVariant1ItemMatcheSignalsBrandImpersonation2()
        {
        }

    }
}