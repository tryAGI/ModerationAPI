
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionsUpdateResponseType2
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
    public static class ActionsUpdateResponseType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateResponseType2 value)
        {
            return value switch
            {
                ActionsUpdateResponseType2.AuthorBlock => "AUTHOR_BLOCK",
                ActionsUpdateResponseType2.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsUpdateResponseType2.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsUpdateResponseType2.AuthorDelete => "AUTHOR_DELETE",
                ActionsUpdateResponseType2.AuthorReport => "AUTHOR_REPORT",
                ActionsUpdateResponseType2.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsUpdateResponseType2.AuthorWarn => "AUTHOR_WARN",
                ActionsUpdateResponseType2.ItemAllow => "ITEM_ALLOW",
                ActionsUpdateResponseType2.ItemCustom => "ITEM_CUSTOM",
                ActionsUpdateResponseType2.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateResponseType2? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsUpdateResponseType2.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsUpdateResponseType2.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsUpdateResponseType2.AuthorCustom,
                "AUTHOR_DELETE" => ActionsUpdateResponseType2.AuthorDelete,
                "AUTHOR_REPORT" => ActionsUpdateResponseType2.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsUpdateResponseType2.AuthorUnblock,
                "AUTHOR_WARN" => ActionsUpdateResponseType2.AuthorWarn,
                "ITEM_ALLOW" => ActionsUpdateResponseType2.ItemAllow,
                "ITEM_CUSTOM" => ActionsUpdateResponseType2.ItemCustom,
                "ITEM_REJECT" => ActionsUpdateResponseType2.ItemReject,
                _ => null,
            };
        }
    }
}