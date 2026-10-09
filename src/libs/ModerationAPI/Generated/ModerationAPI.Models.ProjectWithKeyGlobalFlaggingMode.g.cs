
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it, for testing a setup.
    /// </summary>
    public enum ProjectWithKeyGlobalFlaggingMode
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
    public static class ProjectWithKeyGlobalFlaggingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectWithKeyGlobalFlaggingMode value)
        {
            return value switch
            {
                ProjectWithKeyGlobalFlaggingMode.Active => "ACTIVE",
                ProjectWithKeyGlobalFlaggingMode.DryRun => "DRY_RUN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectWithKeyGlobalFlaggingMode? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ProjectWithKeyGlobalFlaggingMode.Active,
                "DRY_RUN" => ProjectWithKeyGlobalFlaggingMode.DryRun,
                _ => null,
            };
        }
    }
}