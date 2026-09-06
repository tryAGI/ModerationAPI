
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionsCreateResponseType
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
    public static class ActionsCreateResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateResponseType value)
        {
            return value switch
            {
                ActionsCreateResponseType.AuthorBlock => "AUTHOR_BLOCK",
                ActionsCreateResponseType.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsCreateResponseType.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsCreateResponseType.AuthorDelete => "AUTHOR_DELETE",
                ActionsCreateResponseType.AuthorReport => "AUTHOR_REPORT",
                ActionsCreateResponseType.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsCreateResponseType.AuthorWarn => "AUTHOR_WARN",
                ActionsCreateResponseType.ItemAllow => "ITEM_ALLOW",
                ActionsCreateResponseType.ItemCustom => "ITEM_CUSTOM",
                ActionsCreateResponseType.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateResponseType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsCreateResponseType.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsCreateResponseType.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsCreateResponseType.AuthorCustom,
                "AUTHOR_DELETE" => ActionsCreateResponseType.AuthorDelete,
                "AUTHOR_REPORT" => ActionsCreateResponseType.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsCreateResponseType.AuthorUnblock,
                "AUTHOR_WARN" => ActionsCreateResponseType.AuthorWarn,
                "ITEM_ALLOW" => ActionsCreateResponseType.ItemAllow,
                "ITEM_CUSTOM" => ActionsCreateResponseType.ItemCustom,
                "ITEM_REJECT" => ActionsCreateResponseType.ItemReject,
                _ => null,
            };
        }
    }
}