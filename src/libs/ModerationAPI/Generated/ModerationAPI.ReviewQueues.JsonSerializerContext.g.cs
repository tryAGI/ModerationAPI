
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>>), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_8553da6e2cecbbbb")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_aa3397d2851ed486")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>?), TypeInfoPropertyName = "QueueItemContentObjectDataAudio_f7ddcff4010421f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueWithCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.OneOf<global::ModerationAPI.QueueItemContentText, global::ModerationAPI.QueueItemContentImage, global::ModerationAPI.QueueItemContentVideo, global::ModerationAPI.QueueItemContentAudio, global::ModerationAPI.QueueItemContentObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObjectDataText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObjectDataImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObjectDataVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemContentObjectDataAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueItemLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemLabel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueItemLabelMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemLabelMatche))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemLabelMatcheSignals))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemLabelMatcheSignalsBrandImpersonation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemStatus), TypeInfoPropertyName = "QueueItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.Pagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ErrorIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BadRequestErrorCode), TypeInfoPropertyName = "BadRequestErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.ErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthenticationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthenticationErrorCode), TypeInfoPropertyName = "AuthenticationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PermissionDeniedError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PermissionDeniedErrorCode), TypeInfoPropertyName = "PermissionDeniedErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NotFoundError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NotFoundErrorCode), TypeInfoPropertyName = "NotFoundErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RateLimitError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RateLimitErrorCode), TypeInfoPropertyName = "RateLimitErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.InternalServerError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.InternalServerErrorCode), TypeInfoPropertyName = "InternalServerErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSort), TypeInfoPropertyName = "QueueViewOpenGetItemsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseReviewStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrends))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.QueueItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenResolveItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus), TypeInfoPropertyName = "QueueViewOpenUnresolveItemResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueItemStatus?), TypeInfoPropertyName = "NullableQueueItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.BadRequestErrorCode?), TypeInfoPropertyName = "NullableBadRequestErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthenticationErrorCode?), TypeInfoPropertyName = "NullableAuthenticationErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PermissionDeniedErrorCode?), TypeInfoPropertyName = "NullablePermissionDeniedErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.NotFoundErrorCode?), TypeInfoPropertyName = "NullableNotFoundErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.RateLimitErrorCode?), TypeInfoPropertyName = "NullableRateLimitErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.InternalServerErrorCode?), TypeInfoPropertyName = "NullableInternalServerErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenGetItemsSort?), TypeInfoPropertyName = "NullableQueueViewOpenGetItemsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus?), TypeInfoPropertyName = "NullableQueueViewOpenUnresolveItemResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueItemLabel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueItemLabelMatche>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTopReviewer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueViewOpenGetStatsResponseTrendsDailyReviewCount>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.QueueItem>))]
    internal sealed partial class ReviewQueuesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReviewQueuesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


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
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.QueueItemContentText, global::ModerationAPI.QueueItemContentImage, global::ModerationAPI.QueueItemContentVideo, global::ModerationAPI.QueueItemContentAudio, global::ModerationAPI.QueueItemContentObject>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.OneOfJsonConverter<global::ModerationAPI.QueueItemContentObjectDataText, global::ModerationAPI.QueueItemContentObjectDataImage, global::ModerationAPI.QueueItemContentObjectDataVideo, global::ModerationAPI.QueueItemContentObjectDataAudio>());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.AnyOfJsonConverter<string, double?>());
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
                    typeToConvert == typeof(global::ModerationAPI.QueueItemStatus)

                    || typeToConvert == typeof(global::ModerationAPI.QueueItemStatus?)

                    || typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.PermissionDeniedErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.PermissionDeniedErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.InternalServerErrorCode)

                    || typeToConvert == typeof(global::ModerationAPI.InternalServerErrorCode?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSort)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSort?)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus)

                    || typeToConvert == typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ModerationAPI.QueueItemStatus))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueItemStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.BadRequestErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.BadRequestErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.BadRequestErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.AuthenticationErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthenticationErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthenticationErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PermissionDeniedErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.PermissionDeniedErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PermissionDeniedErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.PermissionDeniedErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.NotFoundErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.NotFoundErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.NotFoundErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.RateLimitErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.RateLimitErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.RateLimitErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.InternalServerErrorCode))
                {
                    return new global::ModerationAPI.JsonConverters.InternalServerErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.InternalServerErrorCode?))
                {
                    return new global::ModerationAPI.JsonConverters.InternalServerErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSort))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenGetItemsSort?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenGetItemsSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenUnresolveItemResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.QueueViewOpenUnresolveItemResponseStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.QueueViewOpenUnresolveItemResponseStatusNullableJsonConverter();
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