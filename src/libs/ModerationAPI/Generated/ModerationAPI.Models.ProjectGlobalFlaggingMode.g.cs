
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it, for testing a setup.
    /// </summary>
    public enum ProjectGlobalFlaggingMode
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
    public static class ProjectGlobalFlaggingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectGlobalFlaggingMode value)
        {
            return value switch
            {
                ProjectGlobalFlaggingMode.Active => "ACTIVE",
                ProjectGlobalFlaggingMode.DryRun => "DRY_RUN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectGlobalFlaggingMode? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ProjectGlobalFlaggingMode.Active,
                "DRY_RUN" => ProjectGlobalFlaggingMode.DryRun,
                _ => null,
            };
        }
    }
}