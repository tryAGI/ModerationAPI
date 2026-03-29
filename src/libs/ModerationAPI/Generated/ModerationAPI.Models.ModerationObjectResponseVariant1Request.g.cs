
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Information about the request
    /// </summary>
    public sealed partial class ModerationObjectResponseVariant1Request
    {
        /// <summary>
        /// The timestamp of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// The quota usage of the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quota_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double QuotaUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Request" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp of the request
        /// </param>
        /// <param name="quotaUsage">
        /// The quota usage of the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationObjectResponseVariant1Request(
            double timestamp,
            double quotaUsage)
        {
            this.Timestamp = timestamp;
            this.QuotaUsage = quotaUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Request" /> class.
        /// </summary>
        public ModerationObjectResponseVariant1Request()
        {
        }
    }
}