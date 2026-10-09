
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectGlobalFlaggingMode), TypeInfoPropertyName = "ProjectGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectWithKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode), TypeInfoPropertyName = "ProjectWithKeyGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode), TypeInfoPropertyName = "ManagementProjectsUpdateRequestGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsDuplicateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectGlobalFlaggingMode?), TypeInfoPropertyName = "NullableProjectGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode?), TypeInfoPropertyName = "NullableProjectWithKeyGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode?), TypeInfoPropertyName = "NullableManagementProjectsUpdateRequestGlobalFlaggingMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorBadRequestIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorUnauthorizedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorForbiddenIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorNotFoundIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.Project>))]
    internal sealed partial class ProjectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProjectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProjectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ModerationAPI.ProjectGlobalFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ProjectGlobalFlaggingMode?)

                    || typeToConvert == typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode?)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode)

                    || typeToConvert == typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ModerationAPI.ProjectGlobalFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ProjectGlobalFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ProjectGlobalFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ProjectGlobalFlaggingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ProjectWithKeyGlobalFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ProjectWithKeyGlobalFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ProjectWithKeyGlobalFlaggingModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementProjectsUpdateRequestGlobalFlaggingModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.ManagementProjectsUpdateRequestGlobalFlaggingMode?))
                {
                    return new global::ModerationAPI.JsonConverters.ManagementProjectsUpdateRequestGlobalFlaggingModeNullableJsonConverter();
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
                    0 => new ProjectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}