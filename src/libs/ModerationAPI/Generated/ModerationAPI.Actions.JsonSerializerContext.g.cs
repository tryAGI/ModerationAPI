
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorBadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorBadRequestIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorBadRequestIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorUnauthorized))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorUnauthorizedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorUnauthorizedIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorForbidden))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorForbiddenIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorForbiddenIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorNotFound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorNotFoundIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorNotFoundIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorInternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorInternalServerErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorInternalServerErrorIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorConflict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorConflictIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorConflictIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestType), TypeInfoPropertyName = "ActionsCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour), TypeInfoPropertyName = "ActionsCreateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPosition), TypeInfoPropertyName = "ActionsCreateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestType), TypeInfoPropertyName = "ActionsUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour), TypeInfoPropertyName = "ActionsUpdateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPosition), TypeInfoPropertyName = "ActionsUpdateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteDeprecatedRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemType), TypeInfoPropertyName = "ActionsListResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemQueueBehaviour), TypeInfoPropertyName = "ActionsListResponseItemQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemPosition), TypeInfoPropertyName = "ActionsListResponseItemPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsListResponseItemPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemPossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseType), TypeInfoPropertyName = "ActionsCreateResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour), TypeInfoPropertyName = "ActionsCreateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponsePosition), TypeInfoPropertyName = "ActionsCreateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsCreateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponsePossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseType), TypeInfoPropertyName = "ActionsGetResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour), TypeInfoPropertyName = "ActionsGetResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponsePosition), TypeInfoPropertyName = "ActionsGetResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsGetResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponsePossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseType), TypeInfoPropertyName = "ActionsUpdateResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour), TypeInfoPropertyName = "ActionsUpdateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponsePosition), TypeInfoPropertyName = "ActionsUpdateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ActionsUpdateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponsePossibleValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsExecuteDeprecatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestType?), TypeInfoPropertyName = "NullableActionsCreateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour?), TypeInfoPropertyName = "NullableActionsCreateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateRequestPosition?), TypeInfoPropertyName = "NullableActionsCreateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestType?), TypeInfoPropertyName = "NullableActionsUpdateRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour?), TypeInfoPropertyName = "NullableActionsUpdateRequestQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateRequestPosition?), TypeInfoPropertyName = "NullableActionsUpdateRequestPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemType?), TypeInfoPropertyName = "NullableActionsListResponseItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemQueueBehaviour?), TypeInfoPropertyName = "NullableActionsListResponseItemQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsListResponseItemPosition?), TypeInfoPropertyName = "NullableActionsListResponseItemPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseType?), TypeInfoPropertyName = "NullableActionsCreateResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour?), TypeInfoPropertyName = "NullableActionsCreateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsCreateResponsePosition?), TypeInfoPropertyName = "NullableActionsCreateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseType?), TypeInfoPropertyName = "NullableActionsGetResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour?), TypeInfoPropertyName = "NullableActionsGetResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsGetResponsePosition?), TypeInfoPropertyName = "NullableActionsGetResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseType?), TypeInfoPropertyName = "NullableActionsUpdateResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour?), TypeInfoPropertyName = "NullableActionsUpdateResponseQueueBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ActionsUpdateResponsePosition?), TypeInfoPropertyName = "NullableActionsUpdateResponsePosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorBadRequestIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorUnauthorizedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorForbiddenIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorNotFoundIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorInternalServerErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorConflictIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateRequestPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsListResponseItemPossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsCreateResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsGetResponsePossibleValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ActionsUpdateResponsePossibleValue>))]
    internal sealed partial class ActionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ActionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ActionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::ModerationAPI.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestPosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestPosition?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestPosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestPosition?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemPosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemPosition?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponsePosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponsePosition?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponsePosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsGetResponsePosition?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseType)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseType?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour?)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponsePosition)

                    || typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponsePosition?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestPosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateRequestPosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateRequestPositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestPosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateRequestPosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateRequestPositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseItemQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseItemQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemPosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseItemPositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsListResponseItemPosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsListResponseItemPositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponseQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponseQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponsePosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsCreateResponsePosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsCreateResponsePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponseQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponseQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponsePosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponsePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsGetResponsePosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsGetResponsePositionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseType))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseType?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponseQueueBehaviour?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponseQueueBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponsePosition))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ActionsUpdateResponsePosition?))
                {
                    return new global::ModerationAPI.JsonConverters.ActionsUpdateResponsePositionNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ActionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}