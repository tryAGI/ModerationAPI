
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it.
    /// </summary>
    public enum ChannelFlaggingMode
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
    public static class ChannelFlaggingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelFlaggingMode value)
        {
            return value switch
            {
                ChannelFlaggingMode.Active => "ACTIVE",
                ChannelFlaggingMode.DryRun => "DRY_RUN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelFlaggingMode? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ChannelFlaggingMode.Active,
                "DRY_RUN" => ChannelFlaggingMode.DryRun,
                _ => null,
            };
        }
    }
}