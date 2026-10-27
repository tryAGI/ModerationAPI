
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// The kind of feedback.<br/>
    /// Default Value: feature_request
    /// </summary>
    public enum CreateFeedbackRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Bug,
        /// <summary>
        ///
        /// </summary>
        FeatureRequest,
        /// <summary>
        ///
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFeedbackRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateFeedbackRequestType value)
        {
            return value switch
            {
                CreateFeedbackRequestType.Bug => "bug",
                CreateFeedbackRequestType.FeatureRequest => "feature_request",
                CreateFeedbackRequestType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFeedbackRequestType? ToEnum(string value)
        {
            return value switch
            {
                "bug" => CreateFeedbackRequestType.Bug,
                "feature_request" => CreateFeedbackRequestType.FeatureRequest,
                "other" => CreateFeedbackRequestType.Other,
                _ => null,
            };
        }
    }
}