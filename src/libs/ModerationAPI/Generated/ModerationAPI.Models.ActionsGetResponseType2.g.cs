
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionsGetResponseType2
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
    public static class ActionsGetResponseType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsGetResponseType2 value)
        {
            return value switch
            {
                ActionsGetResponseType2.AuthorBlock => "AUTHOR_BLOCK",
                ActionsGetResponseType2.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsGetResponseType2.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsGetResponseType2.AuthorDelete => "AUTHOR_DELETE",
                ActionsGetResponseType2.AuthorReport => "AUTHOR_REPORT",
                ActionsGetResponseType2.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsGetResponseType2.AuthorWarn => "AUTHOR_WARN",
                ActionsGetResponseType2.ItemAllow => "ITEM_ALLOW",
                ActionsGetResponseType2.ItemCustom => "ITEM_CUSTOM",
                ActionsGetResponseType2.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsGetResponseType2? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsGetResponseType2.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsGetResponseType2.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsGetResponseType2.AuthorCustom,
                "AUTHOR_DELETE" => ActionsGetResponseType2.AuthorDelete,
                "AUTHOR_REPORT" => ActionsGetResponseType2.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsGetResponseType2.AuthorUnblock,
                "AUTHOR_WARN" => ActionsGetResponseType2.AuthorWarn,
                "ITEM_ALLOW" => ActionsGetResponseType2.ItemAllow,
                "ITEM_CUSTOM" => ActionsGetResponseType2.ItemCustom,
                "ITEM_REJECT" => ActionsGetResponseType2.ItemReject,
                _ => null,
            };
        }
    }
}