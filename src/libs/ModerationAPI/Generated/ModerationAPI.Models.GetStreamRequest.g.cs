#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetStreamRequest : global::System.IEquatable<GetStreamRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.GetStreamRequestDiscriminatorEvent? Event { get; }

        /// <summary>
        /// First frame the client sends. Declares the conversation, audio format, and tracks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.VoiceStartFrame? Start { get; init; }
#else
        public global::ModerationAPI.VoiceStartFrame? Start { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Start))]
#endif
        public bool IsStart => Start != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.VoiceStartFrame? value)
        {
            value = Start;
            return IsStart;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.VoiceStartFrame PickStart() => IsStart
            ? Start!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Start' but the value was {ToString()}.");

        /// <summary>
        /// Audio chunk for one track.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.VoiceMediaFrame? Media { get; init; }
#else
        public global::ModerationAPI.VoiceMediaFrame? Media { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Media))]
#endif
        public bool IsMedia => Media != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMedia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.VoiceMediaFrame? value)
        {
            value = Media;
            return IsMedia;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.VoiceMediaFrame PickMedia() => IsMedia
            ? Media!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Media' but the value was {ToString()}.");

        /// <summary>
        /// Ends the call gracefully (or just disconnect).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.VoiceStopFrame? Stop { get; init; }
#else
        public global::ModerationAPI.VoiceStopFrame? Stop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stop))]
#endif
        public bool IsStop => Stop != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.VoiceStopFrame? value)
        {
            value = Stop;
            return IsStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.VoiceStopFrame PickStop() => IsStop
            ? Stop!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Stop' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetStreamRequest(global::ModerationAPI.VoiceStartFrame value) => new GetStreamRequest((global::ModerationAPI.VoiceStartFrame?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.VoiceStartFrame?(GetStreamRequest @this) => @this.Start;

        /// <summary>
        /// 
        /// </summary>
        public GetStreamRequest(global::ModerationAPI.VoiceStartFrame? value)
        {
            Start = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetStreamRequest FromStart(global::ModerationAPI.VoiceStartFrame? value) => new GetStreamRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetStreamRequest(global::ModerationAPI.VoiceMediaFrame value) => new GetStreamRequest((global::ModerationAPI.VoiceMediaFrame?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.VoiceMediaFrame?(GetStreamRequest @this) => @this.Media;

        /// <summary>
        /// 
        /// </summary>
        public GetStreamRequest(global::ModerationAPI.VoiceMediaFrame? value)
        {
            Media = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetStreamRequest FromMedia(global::ModerationAPI.VoiceMediaFrame? value) => new GetStreamRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetStreamRequest(global::ModerationAPI.VoiceStopFrame value) => new GetStreamRequest((global::ModerationAPI.VoiceStopFrame?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.VoiceStopFrame?(GetStreamRequest @this) => @this.Stop;

        /// <summary>
        /// 
        /// </summary>
        public GetStreamRequest(global::ModerationAPI.VoiceStopFrame? value)
        {
            Stop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetStreamRequest FromStop(global::ModerationAPI.VoiceStopFrame? value) => new GetStreamRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public GetStreamRequest(
            global::ModerationAPI.GetStreamRequestDiscriminatorEvent? @event,
            global::ModerationAPI.VoiceStartFrame? start,
            global::ModerationAPI.VoiceMediaFrame? media,
            global::ModerationAPI.VoiceStopFrame? stop
            )
        {
            Event = @event;

            Start = start;
            Media = media;
            Stop = stop;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Stop as object ??
            Media as object ??
            Start as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Start?.ToString() ??
            Media?.ToString() ??
            Stop?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStart && !IsMedia && !IsStop || !IsStart && IsMedia && !IsStop || !IsStart && !IsMedia && IsStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ModerationAPI.VoiceStartFrame, TResult>? start = null,
            global::System.Func<global::ModerationAPI.VoiceMediaFrame, TResult>? media = null,
            global::System.Func<global::ModerationAPI.VoiceStopFrame, TResult>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart && start != null)
            {
                return start(Start!);
            }
            else if (IsMedia && media != null)
            {
                return media(Media!);
            }
            else if (IsStop && stop != null)
            {
                return stop(Stop!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ModerationAPI.VoiceStartFrame>? start = null,

            global::System.Action<global::ModerationAPI.VoiceMediaFrame>? media = null,

            global::System.Action<global::ModerationAPI.VoiceStopFrame>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart)
            {
                start?.Invoke(Start!);
            }
            else if (IsMedia)
            {
                media?.Invoke(Media!);
            }
            else if (IsStop)
            {
                stop?.Invoke(Stop!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ModerationAPI.VoiceStartFrame>? start = null,
            global::System.Action<global::ModerationAPI.VoiceMediaFrame>? media = null,
            global::System.Action<global::ModerationAPI.VoiceStopFrame>? stop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart)
            {
                start?.Invoke(Start!);
            }
            else if (IsMedia)
            {
                media?.Invoke(Media!);
            }
            else if (IsStop)
            {
                stop?.Invoke(Stop!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Start,
                typeof(global::ModerationAPI.VoiceStartFrame),
                Media,
                typeof(global::ModerationAPI.VoiceMediaFrame),
                Stop,
                typeof(global::ModerationAPI.VoiceStopFrame),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(GetStreamRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.VoiceStartFrame?>.Default.Equals(Start, other.Start) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.VoiceMediaFrame?>.Default.Equals(Media, other.Media) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.VoiceStopFrame?>.Default.Equals(Stop, other.Stop) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetStreamRequest obj1, GetStreamRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetStreamRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetStreamRequest obj1, GetStreamRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetStreamRequest o && Equals(o);
        }
    }
}
