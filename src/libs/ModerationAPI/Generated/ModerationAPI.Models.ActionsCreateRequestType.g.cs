
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionsCreateRequestType
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
    public static class ActionsCreateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateRequestType value)
        {
            return value switch
            {
                ActionsCreateRequestType.AuthorBlock => "AUTHOR_BLOCK",
                ActionsCreateRequestType.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsCreateRequestType.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsCreateRequestType.AuthorDelete => "AUTHOR_DELETE",
                ActionsCreateRequestType.AuthorReport => "AUTHOR_REPORT",
                ActionsCreateRequestType.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsCreateRequestType.AuthorWarn => "AUTHOR_WARN",
                ActionsCreateRequestType.ItemAllow => "ITEM_ALLOW",
                ActionsCreateRequestType.ItemCustom => "ITEM_CUSTOM",
                ActionsCreateRequestType.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsCreateRequestType.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsCreateRequestType.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsCreateRequestType.AuthorCustom,
                "AUTHOR_DELETE" => ActionsCreateRequestType.AuthorDelete,
                "AUTHOR_REPORT" => ActionsCreateRequestType.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsCreateRequestType.AuthorUnblock,
                "AUTHOR_WARN" => ActionsCreateRequestType.AuthorWarn,
                "ITEM_ALLOW" => ActionsCreateRequestType.ItemAllow,
                "ITEM_CUSTOM" => ActionsCreateRequestType.ItemCustom,
                "ITEM_REJECT" => ActionsCreateRequestType.ItemReject,
                _ => null,
            };
        }
    }
}