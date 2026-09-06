
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionsGetResponseType
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
    public static class ActionsGetResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsGetResponseType value)
        {
            return value switch
            {
                ActionsGetResponseType.AuthorBlock => "AUTHOR_BLOCK",
                ActionsGetResponseType.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsGetResponseType.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsGetResponseType.AuthorDelete => "AUTHOR_DELETE",
                ActionsGetResponseType.AuthorReport => "AUTHOR_REPORT",
                ActionsGetResponseType.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsGetResponseType.AuthorWarn => "AUTHOR_WARN",
                ActionsGetResponseType.ItemAllow => "ITEM_ALLOW",
                ActionsGetResponseType.ItemCustom => "ITEM_CUSTOM",
                ActionsGetResponseType.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsGetResponseType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsGetResponseType.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsGetResponseType.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsGetResponseType.AuthorCustom,
                "AUTHOR_DELETE" => ActionsGetResponseType.AuthorDelete,
                "AUTHOR_REPORT" => ActionsGetResponseType.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsGetResponseType.AuthorUnblock,
                "AUTHOR_WARN" => ActionsGetResponseType.AuthorWarn,
                "ITEM_ALLOW" => ActionsGetResponseType.ItemAllow,
                "ITEM_CUSTOM" => ActionsGetResponseType.ItemCustom,
                "ITEM_REJECT" => ActionsGetResponseType.ItemReject,
                _ => null,
            };
        }
    }
}