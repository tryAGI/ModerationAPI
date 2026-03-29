
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The flagging mode.
    /// </summary>
    public enum ModerationTextResponseVariant1WordlistMode2
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
    public static class ModerationTextResponseVariant1WordlistMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationTextResponseVariant1WordlistMode2 value)
        {
            return value switch
            {
                ModerationTextResponseVariant1WordlistMode2.BlockList => "BLOCK_LIST",
                ModerationTextResponseVariant1WordlistMode2.PassList => "PASS_LIST",
                ModerationTextResponseVariant1WordlistMode2.RequireList => "REQUIRE_LIST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationTextResponseVariant1WordlistMode2? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK_LIST" => ModerationTextResponseVariant1WordlistMode2.BlockList,
                "PASS_LIST" => ModerationTextResponseVariant1WordlistMode2.PassList,
                "REQUIRE_LIST" => ModerationTextResponseVariant1WordlistMode2.RequireList,
                _ => null,
            };
        }
    }
}