
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Additional metadata provided by your system. We recommend including any relevant information that may assist in the moderation process.
    /// </summary>
    public sealed partial class AuthorOpenCreateRequestMetadata
    {
        /// <summary>
        /// Whether the author's email is verified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// Whether the author's phone number is verified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_verified")]
        public bool? PhoneVerified { get; set; }

        /// <summary>
        /// Whether the author's identity is verified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_verified")]
        public bool? IdentityVerified { get; set; }

        /// <summary>
        /// Whether the author is a paying customer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_paying_customer")]
        public bool? IsPayingCustomer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenCreateRequestMetadata" /> class.
        /// </summary>
        /// <param name="emailVerified">
        /// Whether the author's email is verified
        /// </param>
        /// <param name="phoneVerified">
        /// Whether the author's phone number is verified
        /// </param>
        /// <param name="identityVerified">
        /// Whether the author's identity is verified
        /// </param>
        /// <param name="isPayingCustomer">
        /// Whether the author is a paying customer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthorOpenCreateRequestMetadata(
            bool? emailVerified,
            bool? phoneVerified,
            bool? identityVerified,
            bool? isPayingCustomer)
        {
            this.EmailVerified = emailVerified;
            this.PhoneVerified = phoneVerified;
            this.IdentityVerified = identityVerified;
            this.IsPayingCustomer = isPayingCustomer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorOpenCreateRequestMetadata" /> class.
        /// </summary>
        public AuthorOpenCreateRequestMetadata()
        {
        }
    }
}