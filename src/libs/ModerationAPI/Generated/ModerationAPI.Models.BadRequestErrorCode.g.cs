
#nullable enable

namespace ModerationAPI
{

    /// <summary>
    /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
    /// - `invalid_request`: A parameter is invalid. `message` says which one.<br/>
    /// - `project_id_required`: An organization key called a project endpoint without naming the project in `Project-Id`, and the key reaches more than one project. `message` lists the projects it reaches.<br/>
    /// - `project_name_ambiguous`: The name in `Project-Id` fits more than one project the key reaches. `message` lists them; name the project by ID instead.<br/>
    /// - `validation_failed`: The request body does not match the schema. `issues` lists each problem with its `path`.<br/>
    /// Example: invalid_request
    /// </summary>
    public readonly partial struct BadRequestErrorCode : global::System.IEquatable<BadRequestErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public BadRequestErrorCode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// A parameter is invalid. `message` says which one.
        /// </summary>
        public static BadRequestErrorCode InvalidRequest { get; } = new("invalid_request");

        /// <summary>
        /// An organization key called a project endpoint without naming the project in `Project-Id`, and the key reaches more than one project. `message` lists the projects it reaches.
        /// </summary>
        public static BadRequestErrorCode ProjectIdRequired { get; } = new("project_id_required");

        /// <summary>
        /// The name in `Project-Id` fits more than one project the key reaches. `message` lists them; name the project by ID instead.
        /// </summary>
        public static BadRequestErrorCode ProjectNameAmbiguous { get; } = new("project_name_ambiguous");

        /// <summary>
        /// The request body does not match the schema. `issues` lists each problem with its `path`.
        /// </summary>
        public static BadRequestErrorCode ValidationFailed { get; } = new("validation_failed");
        /// <summary>
        ///
        /// </summary>
        public static BadRequestErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "invalid_request" => InvalidRequest,
                "project_id_required" => ProjectIdRequired,
                "project_name_ambiguous" => ProjectNameAmbiguous,
                "validation_failed" => ValidationFailed,
                _ => new BadRequestErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "invalid_request" => true,
            "project_id_required" => true,
            "project_name_ambiguous" => true,
            "validation_failed" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BadRequestErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BadRequestErrorCode other && Equals(other);
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
        public static bool operator ==(BadRequestErrorCode left, BadRequestErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BadRequestErrorCode left, BadRequestErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BadRequestErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BadRequestErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BadRequestErrorCode? ToEnum(string value)
        {
            return BadRequestErrorCode.FromValue(value);
        }
    }
}