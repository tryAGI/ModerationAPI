
#nullable enable

namespace ModerationAPI
{

    /// <summary>
    /// Exactly what went wrong. Stable; safe to branch on. New codes may be added.<br/>
    /// - `permission_denied`: The API key cannot perform this request.<br/>
    /// - `account_disabled`: The organization account is disabled.<br/>
    /// - `quota_exceeded`: The organization has used all API requests on its plan.<br/>
    /// - `plan_feature_unavailable`: The current plan does not include this feature.<br/>
    /// - `plan_limit_exceeded`: The request goes over a limit of the current plan.<br/>
    /// - `organization_key_required`: This endpoint needs an organization API key, but a project key was used.<br/>
    /// - `missing_key_permission`: The organization key does not have the permission this endpoint needs.<br/>
    /// - `project_not_reachable`: The organization key is limited to other projects.<br/>
    /// Example: permission_denied
    /// </summary>
    public readonly partial struct PermissionDeniedErrorCode : global::System.IEquatable<PermissionDeniedErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public PermissionDeniedErrorCode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// The organization account is disabled.
        /// </summary>
        public static PermissionDeniedErrorCode AccountDisabled { get; } = new("account_disabled");

        /// <summary>
        /// The organization key does not have the permission this endpoint needs.
        /// </summary>
        public static PermissionDeniedErrorCode MissingKeyPermission { get; } = new("missing_key_permission");

        /// <summary>
        /// This endpoint needs an organization API key, but a project key was used.
        /// </summary>
        public static PermissionDeniedErrorCode OrganizationKeyRequired { get; } = new("organization_key_required");

        /// <summary>
        /// The API key cannot perform this request.
        /// </summary>
        public static PermissionDeniedErrorCode PermissionDenied { get; } = new("permission_denied");

        /// <summary>
        /// The current plan does not include this feature.
        /// </summary>
        public static PermissionDeniedErrorCode PlanFeatureUnavailable { get; } = new("plan_feature_unavailable");

        /// <summary>
        /// The request goes over a limit of the current plan.
        /// </summary>
        public static PermissionDeniedErrorCode PlanLimitExceeded { get; } = new("plan_limit_exceeded");

        /// <summary>
        /// The organization key is limited to other projects.
        /// </summary>
        public static PermissionDeniedErrorCode ProjectNotReachable { get; } = new("project_not_reachable");

        /// <summary>
        /// The organization has used all API requests on its plan.
        /// </summary>
        public static PermissionDeniedErrorCode QuotaExceeded { get; } = new("quota_exceeded");
        /// <summary>
        ///
        /// </summary>
        public static PermissionDeniedErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "account_disabled" => AccountDisabled,
                "missing_key_permission" => MissingKeyPermission,
                "organization_key_required" => OrganizationKeyRequired,
                "permission_denied" => PermissionDenied,
                "plan_feature_unavailable" => PlanFeatureUnavailable,
                "plan_limit_exceeded" => PlanLimitExceeded,
                "project_not_reachable" => ProjectNotReachable,
                "quota_exceeded" => QuotaExceeded,
                _ => new PermissionDeniedErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "account_disabled" => true,
            "missing_key_permission" => true,
            "organization_key_required" => true,
            "permission_denied" => true,
            "plan_feature_unavailable" => true,
            "plan_limit_exceeded" => true,
            "project_not_reachable" => true,
            "quota_exceeded" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PermissionDeniedErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PermissionDeniedErrorCode other && Equals(other);
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
        public static bool operator ==(PermissionDeniedErrorCode left, PermissionDeniedErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PermissionDeniedErrorCode left, PermissionDeniedErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionDeniedErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionDeniedErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionDeniedErrorCode? ToEnum(string value)
        {
            return PermissionDeniedErrorCode.FromValue(value);
        }
    }
}