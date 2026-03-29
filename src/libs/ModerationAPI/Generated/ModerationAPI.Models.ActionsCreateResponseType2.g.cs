
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionsCreateResponseType2
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
    public static class ActionsCreateResponseType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateResponseType2 value)
        {
            return value switch
            {
                ActionsCreateResponseType2.AuthorBlock => "AUTHOR_BLOCK",
                ActionsCreateResponseType2.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsCreateResponseType2.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsCreateResponseType2.AuthorDelete => "AUTHOR_DELETE",
                ActionsCreateResponseType2.AuthorReport => "AUTHOR_REPORT",
                ActionsCreateResponseType2.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsCreateResponseType2.AuthorWarn => "AUTHOR_WARN",
                ActionsCreateResponseType2.ItemAllow => "ITEM_ALLOW",
                ActionsCreateResponseType2.ItemCustom => "ITEM_CUSTOM",
                ActionsCreateResponseType2.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateResponseType2? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsCreateResponseType2.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsCreateResponseType2.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsCreateResponseType2.AuthorCustom,
                "AUTHOR_DELETE" => ActionsCreateResponseType2.AuthorDelete,
                "AUTHOR_REPORT" => ActionsCreateResponseType2.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsCreateResponseType2.AuthorUnblock,
                "AUTHOR_WARN" => ActionsCreateResponseType2.AuthorWarn,
                "ITEM_ALLOW" => ActionsCreateResponseType2.ItemAllow,
                "ITEM_CUSTOM" => ActionsCreateResponseType2.ItemCustom,
                "ITEM_REJECT" => ActionsCreateResponseType2.ItemReject,
                _ => null,
            };
        }
    }
}