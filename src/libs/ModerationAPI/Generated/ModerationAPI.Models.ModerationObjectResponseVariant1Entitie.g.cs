
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationObjectResponseVariant1Entitie
    {
        /// <summary>
        /// The model that found the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The matches of the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Matches { get; set; }

        /// <summary>
        /// The similarity score of the matches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Entitie" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that found the entity
        /// </param>
        /// <param name="matches">
        /// The matches of the entity
        /// </param>
        /// <param name="score">
        /// The similarity score of the matches
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationObjectResponseVariant1Entitie(
            string model,
            global::System.Collections.Generic.IList<string> matches,
            double? score)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Matches = matches ?? throw new global::System.ArgumentNullException(nameof(matches));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationObjectResponseVariant1Entitie" /> class.
        /// </summary>
        public ModerationObjectResponseVariant1Entitie()
        {
        }
    }
}