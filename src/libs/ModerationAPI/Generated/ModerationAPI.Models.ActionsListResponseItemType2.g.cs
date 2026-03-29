
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionsListResponseItemType2
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
    public static class ActionsListResponseItemType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListResponseItemType2 value)
        {
            return value switch
            {
                ActionsListResponseItemType2.AuthorBlock => "AUTHOR_BLOCK",
                ActionsListResponseItemType2.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsListResponseItemType2.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsListResponseItemType2.AuthorDelete => "AUTHOR_DELETE",
                ActionsListResponseItemType2.AuthorReport => "AUTHOR_REPORT",
                ActionsListResponseItemType2.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsListResponseItemType2.AuthorWarn => "AUTHOR_WARN",
                ActionsListResponseItemType2.ItemAllow => "ITEM_ALLOW",
                ActionsListResponseItemType2.ItemCustom => "ITEM_CUSTOM",
                ActionsListResponseItemType2.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListResponseItemType2? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsListResponseItemType2.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsListResponseItemType2.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsListResponseItemType2.AuthorCustom,
                "AUTHOR_DELETE" => ActionsListResponseItemType2.AuthorDelete,
                "AUTHOR_REPORT" => ActionsListResponseItemType2.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsListResponseItemType2.AuthorUnblock,
                "AUTHOR_WARN" => ActionsListResponseItemType2.AuthorWarn,
                "ITEM_ALLOW" => ActionsListResponseItemType2.ItemAllow,
                "ITEM_CUSTOM" => ActionsListResponseItemType2.ItemCustom,
                "ITEM_REJECT" => ActionsListResponseItemType2.ItemReject,
                _ => null,
            };
        }
    }
}