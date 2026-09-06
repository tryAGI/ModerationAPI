
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionsUpdateResponseType
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
    public static class ActionsUpdateResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateResponseType value)
        {
            return value switch
            {
                ActionsUpdateResponseType.AuthorBlock => "AUTHOR_BLOCK",
                ActionsUpdateResponseType.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsUpdateResponseType.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsUpdateResponseType.AuthorDelete => "AUTHOR_DELETE",
                ActionsUpdateResponseType.AuthorReport => "AUTHOR_REPORT",
                ActionsUpdateResponseType.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsUpdateResponseType.AuthorWarn => "AUTHOR_WARN",
                ActionsUpdateResponseType.ItemAllow => "ITEM_ALLOW",
                ActionsUpdateResponseType.ItemCustom => "ITEM_CUSTOM",
                ActionsUpdateResponseType.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateResponseType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsUpdateResponseType.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsUpdateResponseType.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsUpdateResponseType.AuthorCustom,
                "AUTHOR_DELETE" => ActionsUpdateResponseType.AuthorDelete,
                "AUTHOR_REPORT" => ActionsUpdateResponseType.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsUpdateResponseType.AuthorUnblock,
                "AUTHOR_WARN" => ActionsUpdateResponseType.AuthorWarn,
                "ITEM_ALLOW" => ActionsUpdateResponseType.ItemAllow,
                "ITEM_CUSTOM" => ActionsUpdateResponseType.ItemCustom,
                "ITEM_REJECT" => ActionsUpdateResponseType.ItemReject,
                _ => null,
            };
        }
    }
}