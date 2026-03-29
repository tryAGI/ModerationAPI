
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The type of content (e.g., "text", "image", "video")
    /// </summary>
    public enum ModerationObjectRequestValueDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationObjectRequestValueDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationObjectRequestValueDataType value)
        {
            return value switch
            {
                ModerationObjectRequestValueDataType.Audio => "audio",
                ModerationObjectRequestValueDataType.Image => "image",
                ModerationObjectRequestValueDataType.Text => "text",
                ModerationObjectRequestValueDataType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationObjectRequestValueDataType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ModerationObjectRequestValueDataType.Audio,
                "image" => ModerationObjectRequestValueDataType.Image,
                "text" => ModerationObjectRequestValueDataType.Text,
                "video" => ModerationObjectRequestValueDataType.Video,
                _ => null,
            };
        }
    }
}