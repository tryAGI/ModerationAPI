
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The flagging mode.
    /// </summary>
    public enum ModerationObjectResponseVariant1WordlistMode
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
    public static class ModerationObjectResponseVariant1WordlistModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationObjectResponseVariant1WordlistMode value)
        {
            return value switch
            {
                ModerationObjectResponseVariant1WordlistMode.BlockList => "BLOCK_LIST",
                ModerationObjectResponseVariant1WordlistMode.PassList => "PASS_LIST",
                ModerationObjectResponseVariant1WordlistMode.RequireList => "REQUIRE_LIST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationObjectResponseVariant1WordlistMode? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK_LIST" => ModerationObjectResponseVariant1WordlistMode.BlockList,
                "PASS_LIST" => ModerationObjectResponseVariant1WordlistMode.PassList,
                "REQUIRE_LIST" => ModerationObjectResponseVariant1WordlistMode.RequireList,
                _ => null,
            };
        }
    }
}