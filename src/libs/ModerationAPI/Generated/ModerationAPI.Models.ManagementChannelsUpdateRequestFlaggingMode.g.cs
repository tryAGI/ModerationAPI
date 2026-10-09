
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it.
    /// </summary>
    public enum ManagementChannelsUpdateRequestFlaggingMode
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
    public static class ManagementChannelsUpdateRequestFlaggingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagementChannelsUpdateRequestFlaggingMode value)
        {
            return value switch
            {
                ManagementChannelsUpdateRequestFlaggingMode.Active => "ACTIVE",
                ManagementChannelsUpdateRequestFlaggingMode.DryRun => "DRY_RUN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagementChannelsUpdateRequestFlaggingMode? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ManagementChannelsUpdateRequestFlaggingMode.Active,
                "DRY_RUN" => ManagementChannelsUpdateRequestFlaggingMode.DryRun,
                _ => null,
            };
        }
    }
}