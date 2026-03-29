
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountLegacyAuthGetResponse
    {
        /// <summary>
        /// Status of the authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Message of the authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLegacyAuthGetResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the authentication
        /// </param>
        /// <param name="message">
        /// Message of the authentication
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountLegacyAuthGetResponse(
            string status,
            string message)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLegacyAuthGetResponse" /> class.
        /// </summary>
        public AccountLegacyAuthGetResponse()
        {
        }
    }
}