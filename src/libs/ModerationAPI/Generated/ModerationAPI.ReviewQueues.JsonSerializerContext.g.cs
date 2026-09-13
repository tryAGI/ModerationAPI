
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenResolveItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSortField), TypeInfoPropertyName = "QueueViewOpenGetItemsSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSortDirection), TypeInfoPropertyName = "QueueViewOpenGetItemsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType), TypeInfoPropertyName = "QueueViewOpenGetQueueResponseQueueFilterFilterLabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction), TypeInfoPropertyName = "QueueViewOpenGetQueueResponseQueueFilterRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrends))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus), TypeInfoPropertyName = "QueueViewOpenGetItemsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenResolveItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSortField?), TypeInfoPropertyName = "NullableQueueViewOpenGetItemsSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSortDirection?), TypeInfoPropertyName = "NullableQueueViewOpenGetItemsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType?), TypeInfoPropertyName = "NullableQueueViewOpenGetQueueResponseQueueFilterFilterLabelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction?), TypeInfoPropertyName = "NullableQueueViewOpenGetQueueResponseQueueFilterRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus?), TypeInfoPropertyName = "NullableQueueViewOpenGetItemsResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorBadRequestIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorUnauthorizedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorForbiddenIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorNotFoundIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorInternalServerErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseActionStat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewerTopAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsFlaggedContentTrend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItemLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetItemsResponseItemAction>))]
    internal sealed partial class ReviewQueuesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReviewQueuesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ReviewQueuesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ReviewQueuesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSortField)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSortField?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSortDirection)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSortDirection?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSortField))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSortField?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSortDirection))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSortDirection?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterFilterLabelType?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterFilterLabelTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterRecommendationActionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetQueueResponseQueueFilterRecommendationAction?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetQueueResponseQueueFilterRecommendationActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsResponseItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsResponseItemStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsResponseItemStatusNullableJsonConverter();
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
                    0 => new ReviewQueuesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}