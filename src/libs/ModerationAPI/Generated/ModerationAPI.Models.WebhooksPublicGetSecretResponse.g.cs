
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhooksPublicGetSecretResponse
    {
        /// <summary>
        /// The signing secret for this project. Every webhook delivery is signed with HMAC-SHA256 over the raw JSON body, hex-encoded in the `modapi-signature` header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Secret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksPublicGetSecretResponse" /> class.
        /// </summary>
        /// <param name="secret">
        /// The signing secret for this project. Every webhook delivery is signed with HMAC-SHA256 over the raw JSON body, hex-encoded in the `modapi-signature` header.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksPublicGetSecretResponse(
            string secret)
        {
            this.Secret = secret ?? throw new global::System.ArgumentNullException(nameof(secret));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksPublicGetSecretResponse" /> class.
        /// </summary>
        public WebhooksPublicGetSecretResponse()
        {
        }

    }
}