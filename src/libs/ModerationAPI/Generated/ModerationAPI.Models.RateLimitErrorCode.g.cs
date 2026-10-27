
#nullable enable

namespace ModerationAPI
{

    /// <summary>
    /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
    /// - `rate_limit_exceeded`: Too many requests. Wait for the `Retry-After` seconds.<br/>
    /// Example: rate_limit_exceeded
    /// </summary>
    public readonly partial struct RateLimitErrorCode : global::System.IEquatable<RateLimitErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public RateLimitErrorCode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// Too many requests. Wait for the `Retry-After` seconds.
        /// </summary>
        public static RateLimitErrorCode RateLimitExceeded { get; } = new("rate_limit_exceeded");
        /// <summary>
        ///
        /// </summary>
        public static RateLimitErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "rate_limit_exceeded" => RateLimitExceeded,
                _ => new RateLimitErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "rate_limit_exceeded" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(RateLimitErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RateLimitErrorCode other && Equals(other);
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
        public static bool operator ==(RateLimitErrorCode left, RateLimitErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RateLimitErrorCode left, RateLimitErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitErrorCode? ToEnum(string value)
        {
            return RateLimitErrorCode.FromValue(value);
        }
    }
}