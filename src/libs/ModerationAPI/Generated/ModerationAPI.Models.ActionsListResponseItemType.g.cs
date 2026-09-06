
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionsListResponseItemType
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
    public static class ActionsListResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListResponseItemType value)
        {
            return value switch
            {
                ActionsListResponseItemType.AuthorBlock => "AUTHOR_BLOCK",
                ActionsListResponseItemType.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsListResponseItemType.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsListResponseItemType.AuthorDelete => "AUTHOR_DELETE",
                ActionsListResponseItemType.AuthorReport => "AUTHOR_REPORT",
                ActionsListResponseItemType.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsListResponseItemType.AuthorWarn => "AUTHOR_WARN",
                ActionsListResponseItemType.ItemAllow => "ITEM_ALLOW",
                ActionsListResponseItemType.ItemCustom => "ITEM_CUSTOM",
                ActionsListResponseItemType.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsListResponseItemType.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsListResponseItemType.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsListResponseItemType.AuthorCustom,
                "AUTHOR_DELETE" => ActionsListResponseItemType.AuthorDelete,
                "AUTHOR_REPORT" => ActionsListResponseItemType.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsListResponseItemType.AuthorUnblock,
                "AUTHOR_WARN" => ActionsListResponseItemType.AuthorWarn,
                "ITEM_ALLOW" => ActionsListResponseItemType.ItemAllow,
                "ITEM_CUSTOM" => ActionsListResponseItemType.ItemCustom,
                "ITEM_REJECT" => ActionsListResponseItemType.ItemReject,
                _ => null,
            };
        }
    }
}