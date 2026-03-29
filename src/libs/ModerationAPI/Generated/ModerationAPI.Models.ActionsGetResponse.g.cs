
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGetResponse
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
        public global::ModerationAPI.ActionsGetResponseType2? Type { get; set; }

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
        /// <default>global::ModerationAPI.ActionsGetResponseQueueBehaviour.NoChange</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("queueBehaviour")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ActionsGetResponseQueueBehaviour QueueBehaviour { get; set; } = global::ModerationAPI.ActionsGetResponseQueueBehaviour.NoChange;

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
        /// <default>global::ModerationAPI.ActionsGetResponsePosition.AllQueues</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ActionsGetResponsePositionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ModerationAPI.ActionsGetResponsePosition Position { get; set; } = global::ModerationAPI.ActionsGetResponsePosition.AllQueues;

        /// <summary>
        /// The possible values of the action. The user will be prompted to select one of these values when executing the action.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("possibleValues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue> PossibleValues { get; set; }

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
        /// The action's webhooks.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponseWebhook> Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetResponse" /> class.
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
        /// <param name="webhooks">
        /// The action's webhooks.<br/>
        /// Default Value: []
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
        public ActionsGetResponse(
            string id,
            string createdAt,
            string name,
            global::ModerationAPI.ActionsGetResponseQueueBehaviour queueBehaviour,
            global::System.Collections.Generic.IList<string> filterInQueueIds,
            global::ModerationAPI.ActionsGetResponsePosition position,
            global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue> possibleValues,
            bool valueRequired,
            bool freeText,
            global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponseWebhook> webhooks,
            string? key,
            string? description,
            global::ModerationAPI.ActionsGetResponseType2? type,
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
            this.Webhooks = webhooks ?? throw new global::System.ArgumentNullException(nameof(webhooks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetResponse" /> class.
        /// </summary>
        public ActionsGetResponse()
        {
        }
    }
}