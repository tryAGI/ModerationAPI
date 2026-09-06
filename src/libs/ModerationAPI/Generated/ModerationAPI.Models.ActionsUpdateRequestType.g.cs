
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionsUpdateRequestType
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
    public static class ActionsUpdateRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsUpdateRequestType value)
        {
            return value switch
            {
                ActionsUpdateRequestType.AuthorBlock => "AUTHOR_BLOCK",
                ActionsUpdateRequestType.AuthorBlockTemp => "AUTHOR_BLOCK_TEMP",
                ActionsUpdateRequestType.AuthorCustom => "AUTHOR_CUSTOM",
                ActionsUpdateRequestType.AuthorDelete => "AUTHOR_DELETE",
                ActionsUpdateRequestType.AuthorReport => "AUTHOR_REPORT",
                ActionsUpdateRequestType.AuthorUnblock => "AUTHOR_UNBLOCK",
                ActionsUpdateRequestType.AuthorWarn => "AUTHOR_WARN",
                ActionsUpdateRequestType.ItemAllow => "ITEM_ALLOW",
                ActionsUpdateRequestType.ItemCustom => "ITEM_CUSTOM",
                ActionsUpdateRequestType.ItemReject => "ITEM_REJECT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsUpdateRequestType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHOR_BLOCK" => ActionsUpdateRequestType.AuthorBlock,
                "AUTHOR_BLOCK_TEMP" => ActionsUpdateRequestType.AuthorBlockTemp,
                "AUTHOR_CUSTOM" => ActionsUpdateRequestType.AuthorCustom,
                "AUTHOR_DELETE" => ActionsUpdateRequestType.AuthorDelete,
                "AUTHOR_REPORT" => ActionsUpdateRequestType.AuthorReport,
                "AUTHOR_UNBLOCK" => ActionsUpdateRequestType.AuthorUnblock,
                "AUTHOR_WARN" => ActionsUpdateRequestType.AuthorWarn,
                "ITEM_ALLOW" => ActionsUpdateRequestType.ItemAllow,
                "ITEM_CUSTOM" => ActionsUpdateRequestType.ItemCustom,
                "ITEM_REJECT" => ActionsUpdateRequestType.ItemReject,
                _ => null,
            };
        }
    }
}