
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionsListResponseDataItemType
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
    public static class ActionsListResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListResponseDataItemType value)
        {
            return value switch
            {
                ActionsListResponseDataItemType.AuthorBlock => "AUTHOR_BLOCK",
                ActionsListResponseDataItemType.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsListResponseDataItemType.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsListResponseDataItemType.AuthorDelete => "AUTHOR_DELETE",
                ActionsListResponseDataItemType.AuthorReport => "AUTHOR_REPORT",
                ActionsListResponseDataItemType.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsListResponseDataItemType.AuthorWarn => "AUTHOR_WARN",
                ActionsListResponseDataItemType.ItemAllow => "ITEM_ALLOW",
                ActionsListResponseDataItemType.ItemCustom => "ITEM_CUSTOM",
                ActionsListResponseDataItemType.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsListResponseDataItemType.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsListResponseDataItemType.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsListResponseDataItemType.AuthorCustom,
                "AUTHOR_DELETE" => ActionsListResponseDataItemType.AuthorDelete,
                "AUTHOR_REPORT" => ActionsListResponseDataItemType.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsListResponseDataItemType.AuthorUnblock,
                "AUTHOR_WARN" => ActionsListResponseDataItemType.AuthorWarn,
                "ITEM_ALLOW" => ActionsListResponseDataItemType.ItemAllow,
                "ITEM_CUSTOM" => ActionsListResponseDataItemType.ItemCustom,
                "ITEM_REJECT" => ActionsListResponseDataItemType.ItemReject,
                _ => null,
            };
        }
    }
}