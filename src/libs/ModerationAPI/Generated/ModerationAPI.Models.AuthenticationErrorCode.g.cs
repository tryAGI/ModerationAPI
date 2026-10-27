
#nullable enable

namespace ModerationAPI
{

    /// <summary>
    /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
    /// - `unauthorized`: Authentication failed.<br/>
    /// - `missing_api_key`: No API key in the `Authorization` header.<br/>
    /// - `malformed_api_key`: The `Authorization` header does not contain a valid key format.<br/>
    /// - `invalid_api_key`: The API key does not exist or was revoked.<br/>
    /// Example: unauthorized
    /// </summary>
    public readonly partial struct AuthenticationErrorCode : global::System.IEquatable<AuthenticationErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public AuthenticationErrorCode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// The API key does not exist or was revoked.
        /// </summary>
        public static AuthenticationErrorCode InvalidApiKey { get; } = new("invalid_api_key");

        /// <summary>
        /// The `Authorization` header does not contain a valid key format.
        /// </summary>
        public static AuthenticationErrorCode MalformedApiKey { get; } = new("malformed_api_key");

        /// <summary>
        /// No API key in the `Authorization` header.
        /// </summary>
        public static AuthenticationErrorCode MissingApiKey { get; } = new("missing_api_key");

        /// <summary>
        /// Authentication failed.
        /// </summary>
        public static AuthenticationErrorCode Unauthorized { get; } = new("unauthorized");
        /// <summary>
        ///
        /// </summary>
        public static AuthenticationErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "invalid_api_key" => InvalidApiKey,
                "malformed_api_key" => MalformedApiKey,
                "missing_api_key" => MissingApiKey,
                "unauthorized" => Unauthorized,
                _ => new AuthenticationErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "invalid_api_key" => true,
            "malformed_api_key" => true,
            "missing_api_key" => true,
            "unauthorized" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AuthenticationErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthenticationErrorCode other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AuthenticationErrorCode left, AuthenticationErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AuthenticationErrorCode left, AuthenticationErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthenticationErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationErrorCode? ToEnum(string value)
        {
            return AuthenticationErrorCode.FromValue(value);
        }
    }
}