
#nullable enable

namespace ModerationAPI
{

    /// <summary>
    /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
    /// - `internal_error`: Something went wrong on our side. Retry with backoff.<br/>
    /// Example: internal_error
    /// </summary>
    public readonly partial struct InternalServerErrorCode : global::System.IEquatable<InternalServerErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public InternalServerErrorCode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// Something went wrong on our side. Retry with backoff.
        /// </summary>
        public static InternalServerErrorCode InternalError { get; } = new("internal_error");
        /// <summary>
        ///
        /// </summary>
        public static InternalServerErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "internal_error" => InternalError,
                _ => new InternalServerErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "internal_error" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InternalServerErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternalServerErrorCode other && Equals(other);
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
        public static bool operator ==(InternalServerErrorCode left, InternalServerErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternalServerErrorCode left, InternalServerErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternalServerErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternalServerErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternalServerErrorCode? ToEnum(string value)
        {
            return InternalServerErrorCode.FromValue(value);
        }
    }
}