
#nullable enable

namespace ModerationAPI
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.Channel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelContentType), TypeInfoPropertyName = "ChannelContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelFlaggingMode), TypeInfoPropertyName = "ChannelFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelTranscriptionQuality), TypeInfoPropertyName = "ChannelTranscriptionQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType), TypeInfoPropertyName = "ManagementChannelsCreateRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType), TypeInfoPropertyName = "ManagementChannelsUpdateRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode), TypeInfoPropertyName = "ManagementChannelsUpdateRequestFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality), TypeInfoPropertyName = "ManagementChannelsUpdateRequestTranscriptionQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.Channel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelContentType?), TypeInfoPropertyName = "NullableChannelContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelFlaggingMode?), TypeInfoPropertyName = "NullableChannelFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ChannelTranscriptionQuality?), TypeInfoPropertyName = "NullableChannelTranscriptionQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType?), TypeInfoPropertyName = "NullableManagementChannelsCreateRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType?), TypeInfoPropertyName = "NullableManagementChannelsUpdateRequestContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode?), TypeInfoPropertyName = "NullableManagementChannelsUpdateRequestFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality?), TypeInfoPropertyName = "NullableManagementChannelsUpdateRequestTranscriptionQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorBadRequestIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorUnauthorizedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorForbiddenIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorNotFoundIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.Channel>))]
    internal sealed partial class ChannelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChannelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ChannelsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ChannelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ModerationAPI.ChannelContentType)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelContentType?)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelFlaggingMode?)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelTranscriptionQuality)

                    || typeToConvert == typeof(global::ModerationAPI.ChannelTranscriptionQuality?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ModerationAPI.ChannelContentType))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelContentType?))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelFlaggingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelTranscriptionQuality))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelTranscriptionQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ChannelTranscriptionQuality?))
                {
                    return new global::ModerationAPI.JsonConverters.ChannelTranscriptionQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsCreateRequestContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsCreateRequestContentType?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsCreateRequestContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestContentType?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestFlaggingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestTranscriptionQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementChannelsUpdateRequestTranscriptionQualityNullableJsonConverter();
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
                    0 => new ChannelsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}