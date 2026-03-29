
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsUpdateResponse
    {
        /// <summary>
        /// The ID of the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// User defined key of the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The date the action was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The name of the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The type of the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::ModerationAPI.ActionsUpdateResponseType2? Type { get; set; }

        /// <summary>
        /// Whether the action is a built-in action or a custom one.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builtIn")]
        public bool? BuiltIn { get; set; }

        /// <summary>
        /// Whether the action resolves and removes the item, unresolves and re-add it to the queue, or does not change the resolve status.<br/>
        /// Default Value: NO_CHANGE
        /// </summary>
        /// <default>global::ModerationAPI.ActionsUpdateResponseQueueBehaviour.NoChange</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueBehaviour")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ActionsUpdateResponseQueueBehaviour QueueBehaviour { get; set; } = global::ModerationAPI.ActionsUpdateResponseQueueBehaviour.NoChange;

        /// <summary>
        /// The IDs of the queues the action is available in.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterInQueueIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FilterInQueueIds { get; set; }

        /// <summary>
        /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
        /// Default Value: ALL_QUEUES
        /// </summary>
        /// <default>global::ModerationAPI.ActionsUpdateResponsePosition.AllQueues</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ActionsUpdateResponsePosition Position { get; set; } = global::ModerationAPI.ActionsUpdateResponsePosition.AllQueues;

        /// <summary>
        /// The possible values of the action. The user will be prompted to select one of these values when executing the action.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("possibleValues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue> PossibleValues { get; set; }

        /// <summary>
        /// Whether the action requires a value to be executed.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueRequired")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ValueRequired { get; set; }

        /// <summary>
        /// Whether the action allows any text to be entered as a value or if it must be one of the possible values.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool FreeText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the action.
        /// </param>
        /// <param name="createdAt">
        /// The date the action was created.
        /// </param>
        /// <param name="name">
        /// The name of the action.
        /// </param>
        /// <param name="queueBehaviour">
        /// Whether the action resolves and removes the item, unresolves and re-add it to the queue, or does not change the resolve status.<br/>
        /// Default Value: NO_CHANGE
        /// </param>
        /// <param name="filterInQueueIds">
        /// The IDs of the queues the action is available in.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="position">
        /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
        /// Default Value: ALL_QUEUES
        /// </param>
        /// <param name="possibleValues">
        /// The possible values of the action. The user will be prompted to select one of these values when executing the action.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="valueRequired">
        /// Whether the action requires a value to be executed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="freeText">
        /// Whether the action allows any text to be entered as a value or if it must be one of the possible values.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="key">
        /// User defined key of the action.
        /// </param>
        /// <param name="description">
        /// The description of the action.
        /// </param>
        /// <param name="type">
        /// The type of the action.
        /// </param>
        /// <param name="builtIn">
        /// Whether the action is a built-in action or a custom one.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsUpdateResponse(
            string id,
            string createdAt,
            string name,
            global::ModerationAPI.ActionsUpdateResponseQueueBehaviour queueBehaviour,
            global::System.Collections.Generic.IList<string> filterInQueueIds,
            global::ModerationAPI.ActionsUpdateResponsePosition position,
            global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue> possibleValues,
            bool valueRequired,
            bool freeText,
            string? key,
            string? description,
            global::ModerationAPI.ActionsUpdateResponseType2? type,
            bool? builtIn)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Key = key;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type;
            this.BuiltIn = builtIn;
            this.QueueBehaviour = queueBehaviour;
            this.FilterInQueueIds = filterInQueueIds ?? throw new global::System.ArgumentNullException(nameof(filterInQueueIds));
            this.Position = position;
            this.PossibleValues = possibleValues ?? throw new global::System.ArgumentNullException(nameof(possibleValues));
            this.ValueRequired = valueRequired;
            this.FreeText = freeText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateResponse" /> class.
        /// </summary>
        public ActionsUpdateResponse()
        {
        }
    }
}