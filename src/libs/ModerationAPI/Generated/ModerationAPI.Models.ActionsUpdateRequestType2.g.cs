
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionsUpdateRequestType2
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorBlock,
        /// <summary>
        /// 
        /// </summary>
        AuthorBlockTemp,
        /// <summary>
        /// 
        /// </summary>
        AuthorCustom,
        /// <summary>
        /// 
        /// </summary>
        AuthorDelete,
        /// <summary>
        /// 
        /// </summary>
        AuthorReport,
        /// <summary>
        /// 
        /// </summary>
        AuthorUnblock,
        /// <summary>
        /// 
        /// </summary>
        AuthorWarn,
        /// <summary>
        /// 
        /// </summary>
        ItemAllow,
        /// <summary>
        /// 
        /// </summary>
        ItemCustom,
        /// <summary>
        /// 
        /// </summary>
        ItemReject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsUpdateRequestType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateRequestType2 value)
        {
            return value switch
            {
                ActionsUpdateRequestType2.AuthorBlock => "AUTHOR_BLOCK",
                ActionsUpdateRequestType2.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsUpdateRequestType2.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsUpdateRequestType2.AuthorDelete => "AUTHOR_DELETE",
                ActionsUpdateRequestType2.AuthorReport => "AUTHOR_REPORT",
                ActionsUpdateRequestType2.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsUpdateRequestType2.AuthorWarn => "AUTHOR_WARN",
                ActionsUpdateRequestType2.ItemAllow => "ITEM_ALLOW",
                ActionsUpdateRequestType2.ItemCustom => "ITEM_CUSTOM",
                ActionsUpdateRequestType2.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateRequestType2? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsUpdateRequestType2.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsUpdateRequestType2.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsUpdateRequestType2.AuthorCustom,
                "AUTHOR_DELETE" => ActionsUpdateRequestType2.AuthorDelete,
                "AUTHOR_REPORT" => ActionsUpdateRequestType2.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsUpdateRequestType2.AuthorUnblock,
                "AUTHOR_WARN" => ActionsUpdateRequestType2.AuthorWarn,
                "ITEM_ALLOW" => ActionsUpdateRequestType2.ItemAllow,
                "ITEM_CUSTOM" => ActionsUpdateRequestType2.ItemCustom,
                "ITEM_REJECT" => ActionsUpdateRequestType2.ItemReject,
                _ => null,
            };
        }
    }
}