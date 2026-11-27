
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// `BLOCK_LIST` flags content that matches. `REQUIRE_LIST` flags content that does not match. `PASS_LIST` never flags, but still returns matches and masks them.
    /// </summary>
    public enum ChannelWordlistType
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
    public static class ChannelWordlistTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelWordlistType value)
        {
            return value switch
            {
                ChannelWordlistType.BlockList => "BLOCK_LIST",
                ChannelWordlistType.PassList => "PASS_LIST",
                ChannelWordlistType.RequireList => "REQUIRE_LIST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelWordlistType? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK_LIST" => ChannelWordlistType.BlockList,
                "PASS_LIST" => ChannelWordlistType.PassList,
                "REQUIRE_LIST" => ChannelWordlistType.RequireList,
                _ => null,
            };
        }
    }
}