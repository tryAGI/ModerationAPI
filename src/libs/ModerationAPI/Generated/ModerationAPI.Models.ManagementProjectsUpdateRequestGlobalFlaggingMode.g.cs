
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `ACTIVE` flags content. `DRY_RUN` evaluates without flagging.
    /// </summary>
    public enum ManagementProjectsUpdateRequestGlobalFlaggingMode
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        DryRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagementProjectsUpdateRequestGlobalFlaggingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagementProjectsUpdateRequestGlobalFlaggingMode value)
        {
            return value switch
            {
                ManagementProjectsUpdateRequestGlobalFlaggingMode.Active => "ACTIVE",
                ManagementProjectsUpdateRequestGlobalFlaggingMode.DryRun => "DRY_RUN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagementProjectsUpdateRequestGlobalFlaggingMode? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ManagementProjectsUpdateRequestGlobalFlaggingMode.Active,
                "DRY_RUN" => ManagementProjectsUpdateRequestGlobalFlaggingMode.DryRun,
                _ => null,
            };
        }
    }
}