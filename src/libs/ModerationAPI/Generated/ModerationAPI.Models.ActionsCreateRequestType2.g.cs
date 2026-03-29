
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionsCreateRequestType2
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
    public static class ActionsCreateRequestType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateRequestType2 value)
        {
            return value switch
            {
                ActionsCreateRequestType2.AuthorBlock => "AUTHOR_BLOCK",
                ActionsCreateRequestType2.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsCreateRequestType2.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsCreateRequestType2.AuthorDelete => "AUTHOR_DELETE",
                ActionsCreateRequestType2.AuthorReport => "AUTHOR_REPORT",
                ActionsCreateRequestType2.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsCreateRequestType2.AuthorWarn => "AUTHOR_WARN",
                ActionsCreateRequestType2.ItemAllow => "ITEM_ALLOW",
                ActionsCreateRequestType2.ItemCustom => "ITEM_CUSTOM",
                ActionsCreateRequestType2.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateRequestType2? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsCreateRequestType2.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsCreateRequestType2.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsCreateRequestType2.AuthorCustom,
                "AUTHOR_DELETE" => ActionsCreateRequestType2.AuthorDelete,
                "AUTHOR_REPORT" => ActionsCreateRequestType2.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsCreateRequestType2.AuthorUnblock,
                "AUTHOR_WARN" => ActionsCreateRequestType2.AuthorWarn,
                "ITEM_ALLOW" => ActionsCreateRequestType2.ItemAllow,
                "ITEM_CUSTOM" => ActionsCreateRequestType2.ItemCustom,
                "ITEM_REJECT" => ActionsCreateRequestType2.ItemReject,
                _ => null,
            };
        }
    }
}