
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsCreateRequest
    {
        /// <summary>
        /// User defined key of the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

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
        public global::ModerationAPI.ActionsCreateRequestType2? Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("queueBehaviour")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourJsonConverter))]
        public global::ModerationAPI.ActionsCreateRequestQueueBehaviour? QueueBehaviour { get; set; }

        /// <summary>
        /// The IDs of the queues the action is available in.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterInQueueIds")]
        public global::System.Collections.Generic.IList<string>? FilterInQueueIds { get; set; }

        /// <summary>
        /// Show the action in all queues, selected queues or no queues (to use via API only).<br/>
        /// Default Value: ALL_QUEUES
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionJsonConverter))]
        public global::ModerationAPI.ActionsCreateRequestPosition? Position { get; set; }

        /// <summary>
        /// The possible values of the action. The user will be prompted to select one of these values when executing the action.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("possibleValues")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>? PossibleValues { get; set; }

        /// <summary>
        /// Whether the action requires a value to be executed.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valueRequired")]
        public bool? ValueRequired { get; set; }

        /// <summary>
        /// Whether the action allows any text to be entered as a value or if it must be one of the possible values.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeText")]
        public bool? FreeText { get; set; }

        /// <summary>
        /// The action's webhooks.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestWebhook>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the action.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsCreateRequest(
            string name,
            string? key,
            string? description,
            global::ModerationAPI.ActionsCreateRequestType2? type,
            bool? builtIn,
            global::ModerationAPI.ActionsCreateRequestQueueBehaviour? queueBehaviour,
            global::System.Collections.Generic.IList<string>? filterInQueueIds,
            global::ModerationAPI.ActionsCreateRequestPosition? position,
            global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>? possibleValues,
            bool? valueRequired,
            bool? freeText,
            global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestWebhook>? webhooks)
        {
            this.Key = key;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Type = type;
            this.BuiltIn = builtIn;
            this.QueueBehaviour = queueBehaviour;
            this.FilterInQueueIds = filterInQueueIds;
            this.Position = position;
            this.PossibleValues = possibleValues;
            this.ValueRequired = valueRequired;
            this.FreeText = freeText;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateRequest" /> class.
        /// </summary>
        public ActionsCreateRequest()
        {
        }
    }
}