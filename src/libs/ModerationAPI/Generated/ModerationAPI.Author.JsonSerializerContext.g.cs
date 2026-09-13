
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorStatus), TypeInfoPropertyName = "PublicAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorTrustLevel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorRiskEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorMetadata))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenCreateRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenUpdateRequestMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy), TypeInfoPropertyName = "AuthorOpenListAuthorsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection), TypeInfoPropertyName = "AuthorOpenListAuthorsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ModerationAPI.PublicAuthor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsResponsePagination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.PublicAuthorStatus?), TypeInfoPropertyName = "NullablePublicAuthorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy?), TypeInfoPropertyName = "NullableAuthorOpenListAuthorsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection?), TypeInfoPropertyName = "NullableAuthorOpenListAuthorsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorBadRequestIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorUnauthorizedIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorForbiddenIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorNotFoundIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.ErrorInternalServerErrorIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ModerationAPI.PublicAuthor>))]
    internal sealed partial class AuthorSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthorSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AuthorSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AuthorSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ModerationAPI.PublicAuthorStatus)

                    || typeToConvert == typeof(global::ModerationAPI.PublicAuthorStatus?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy?)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection)

                    || typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ModerationAPI.PublicAuthorStatus))
                {
                    return new global::ModerationAPI.JsonConverters.PublicAuthorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.PublicAuthorStatus?))
                {
                    return new global::ModerationAPI.JsonConverters.PublicAuthorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortBy?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ModerationAPI.AuthorOpenListAuthorsSortDirection?))
                {
                    return new global::ModerationAPI.JsonConverters.AuthorOpenListAuthorsSortDirectionNullableJsonConverter();
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
                    0 => new AuthorSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}