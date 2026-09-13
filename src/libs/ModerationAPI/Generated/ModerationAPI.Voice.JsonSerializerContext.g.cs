
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameEvent), TypeInfoPropertyName = "VoiceStartFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameMediaFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.VoiceStartFrameTrack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameTrack))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameTrackName), TypeInfoPropertyName = "VoiceStartFrameTrackName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameEvent), TypeInfoPropertyName = "VoiceMediaFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameMedia))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack), TypeInfoPropertyName = "VoiceMediaFrameMediaTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStopFrame))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStopFrameEvent), TypeInfoPropertyName = "VoiceStopFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionStartedEvent), TypeInfoPropertyName = "VoiceSessionStartedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalEvent), TypeInfoPropertyName = "VoiceUtteranceFinalEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalTrack), TypeInfoPropertyName = "VoiceUtteranceFinalTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction), TypeInfoPropertyName = "VoiceUtteranceFinalRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEnded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEndedEvent), TypeInfoPropertyName = "VoiceSessionEndedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEndedStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEndedStatsActions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamRequest), TypeInfoPropertyName = "GetStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamRequestDiscriminatorEvent), TypeInfoPropertyName = "GetStreamRequestDiscriminatorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamSecWebSocketProtocol), TypeInfoPropertyName = "GetStreamSecWebSocketProtocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamResponse), TypeInfoPropertyName = "GetStreamResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamResponseDiscriminatorEvent), TypeInfoPropertyName = "GetStreamResponseDiscriminatorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameEvent?), TypeInfoPropertyName = "NullableVoiceStartFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStartFrameTrackName?), TypeInfoPropertyName = "NullableVoiceStartFrameTrackName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameEvent?), TypeInfoPropertyName = "NullableVoiceMediaFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack?), TypeInfoPropertyName = "NullableVoiceMediaFrameMediaTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceStopFrameEvent?), TypeInfoPropertyName = "NullableVoiceStopFrameEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionStartedEvent?), TypeInfoPropertyName = "NullableVoiceSessionStartedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalEvent?), TypeInfoPropertyName = "NullableVoiceUtteranceFinalEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalTrack?), TypeInfoPropertyName = "NullableVoiceUtteranceFinalTrack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction?), TypeInfoPropertyName = "NullableVoiceUtteranceFinalRecommendationAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.VoiceSessionEndedEvent?), TypeInfoPropertyName = "NullableVoiceSessionEndedEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamRequest?), TypeInfoPropertyName = "NullableGetStreamRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamRequestDiscriminatorEvent?), TypeInfoPropertyName = "NullableGetStreamRequestDiscriminatorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamSecWebSocketProtocol?), TypeInfoPropertyName = "NullableGetStreamSecWebSocketProtocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamResponse?), TypeInfoPropertyName = "NullableGetStreamResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.GetStreamResponseDiscriminatorEvent?), TypeInfoPropertyName = "NullableGetStreamResponseDiscriminatorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.VoiceStartFrameTrack>))]
    internal sealed partial class VoiceSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoiceSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoiceSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::ModerationAPI.JsonConverters.GetStreamRequestJsonConverter());
            options.Converters.Add(new global::ModerationAPI.JsonConverters.GetStreamResponseJsonConverter());
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
                    typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameTrackName)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameTrackName?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStopFrameEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceStopFrameEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceSessionStartedEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceSessionStartedEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalTrack)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalTrack?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction?)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceSessionEndedEvent)

                    || typeToConvert == typeof(global::ModerationAPI.VoiceSessionEndedEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.GetStreamRequestDiscriminatorEvent)

                    || typeToConvert == typeof(global::ModerationAPI.GetStreamRequestDiscriminatorEvent?)

                    || typeToConvert == typeof(global::ModerationAPI.GetStreamSecWebSocketProtocol)

                    || typeToConvert == typeof(global::ModerationAPI.GetStreamSecWebSocketProtocol?)

                    || typeToConvert == typeof(global::ModerationAPI.GetStreamResponseDiscriminatorEvent)

                    || typeToConvert == typeof(global::ModerationAPI.GetStreamResponseDiscriminatorEvent?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStartFrameEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStartFrameEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameTrackName))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStartFrameTrackNameJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStartFrameTrackName?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStartFrameTrackNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceMediaFrameEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceMediaFrameEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceMediaFrameMediaTrackJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceMediaFrameMediaTrack?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceMediaFrameMediaTrackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStopFrameEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStopFrameEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceStopFrameEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceStopFrameEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceSessionStartedEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceSessionStartedEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceSessionStartedEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceSessionStartedEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalTrack))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalTrackJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalTrack?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalTrackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalRecommendationActionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceUtteranceFinalRecommendationAction?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceUtteranceFinalRecommendationActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceSessionEndedEvent))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceSessionEndedEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.VoiceSessionEndedEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.VoiceSessionEndedEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetStreamRequestDiscriminatorEvent))
                {
                    return new global::ModerationAPI.JsonConverters.GetStreamRequestDiscriminatorEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetStreamRequestDiscriminatorEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.GetStreamRequestDiscriminatorEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetStreamSecWebSocketProtocol))
                {
                    return new global::ModerationAPI.JsonConverters.GetStreamSecWebSocketProtocolJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetStreamSecWebSocketProtocol?))
                {
                    return new global::ModerationAPI.JsonConverters.GetStreamSecWebSocketProtocolNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetStreamResponseDiscriminatorEvent))
                {
                    return new global::ModerationAPI.JsonConverters.GetStreamResponseDiscriminatorEventJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.GetStreamResponseDiscriminatorEvent?))
                {
                    return new global::ModerationAPI.JsonConverters.GetStreamResponseDiscriminatorEventNullableJsonConverter();
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
                    0 => new VoiceSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}