
#nullable enable

namespace ModerationAPI
{

    /// <summary>
    /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
    /// - `unprocessable_content`: The request is valid but cannot be processed.<br/>
    /// Example: unprocessable_content
    /// </summary>
    public readonly partial struct UnprocessableEntityErrorCode : global::System.IEquatable<UnprocessableEntityErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public UnprocessableEntityErrorCode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// The request is valid but cannot be processed.
        /// </summary>
        public static UnprocessableEntityErrorCode UnprocessableContent { get; } = new("unprocessable_content");
        /// <summary>
        ///
        /// </summary>
        public static UnprocessableEntityErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "unprocessable_content" => UnprocessableContent,
                _ => new UnprocessableEntityErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "unprocessable_content" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(UnprocessableEntityErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UnprocessableEntityErrorCode other && Equals(other);
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
        public static bool operator ==(UnprocessableEntityErrorCode left, UnprocessableEntityErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UnprocessableEntityErrorCode left, UnprocessableEntityErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnprocessableEntityErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnprocessableEntityErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnprocessableEntityErrorCode? ToEnum(string value)
        {
            return UnprocessableEntityErrorCode.FromValue(value);
        }
    }
}