
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `BLOCK_LIST` flags content that matches. `REQUIRE_LIST` flags content that does not match. `PASS_LIST` never flags, but still returns matches and masks them.
    /// </summary>
    public enum UpdateChannelWordlistsRequestWordlistType
    {
        /// <summary>
        ///
        /// </summary>
        BlockList,
        /// <summary>
        ///
        /// </summary>
        PassList,
        /// <summary>
        ///
        /// </summary>
        RequireList,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateChannelWordlistsRequestWordlistTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateChannelWordlistsRequestWordlistType value)
        {
            return value switch
            {
                UpdateChannelWordlistsRequestWordlistType.BlockList => "BLOCK_LIST",
                UpdateChannelWordlistsRequestWordlistType.PassList => "PASS_LIST",
                UpdateChannelWordlistsRequestWordlistType.RequireList => "REQUIRE_LIST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChannelWordlistsRequestWordlistType? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK_LIST" => UpdateChannelWordlistsRequestWordlistType.BlockList,
                "PASS_LIST" => UpdateChannelWordlistsRequestWordlistType.PassList,
                "REQUIRE_LIST" => UpdateChannelWordlistsRequestWordlistType.RequireList,
                _ => null,
            };
        }
    }
}