#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetStreamResponse : global::System.IEquatable<GetStreamResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.GetStreamResponseDiscriminatorEvent? Event { get; }

        /// <summary>
        /// Sent after the start frame is accepted.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.VoiceSessionStarted? SessionStarted { get; init; }
#else
        public global::ModerationAPI.VoiceSessionStarted? SessionStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStarted))]
#endif
        public bool IsSessionStarted => SessionStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.VoiceSessionStarted? value)
        {
            value = SessionStarted;
            return IsSessionStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.VoiceSessionStarted PickSessionStarted() => IsSessionStarted
            ? SessionStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionStarted' but the value was {ToString()}.");

        /// <summary>
        /// A finalized utterance with its moderation result. The evaluation/recommendation/policies match the standard moderation response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.VoiceUtteranceFinal? UtteranceFinal { get; init; }
#else
        public global::ModerationAPI.VoiceUtteranceFinal? UtteranceFinal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UtteranceFinal))]
#endif
        public bool IsUtteranceFinal => UtteranceFinal != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUtteranceFinal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.VoiceUtteranceFinal? value)
        {
            value = UtteranceFinal;
            return IsUtteranceFinal;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.VoiceUtteranceFinal PickUtteranceFinal() => IsUtteranceFinal
            ? UtteranceFinal!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UtteranceFinal' but the value was {ToString()}.");

        /// <summary>
        /// Sent when the call ends, with summary stats.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.VoiceSessionEnded? SessionEnded { get; init; }
#else
        public global::ModerationAPI.VoiceSessionEnded? SessionEnded { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionEnded))]
#endif
        public bool IsSessionEnded => SessionEnded != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionEnded(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.VoiceSessionEnded? value)
        {
            value = SessionEnded;
            return IsSessionEnded;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.VoiceSessionEnded PickSessionEnded() => IsSessionEnded
            ? SessionEnded!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionEnded' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetStreamResponse(global::ModerationAPI.VoiceSessionStarted value) => new GetStreamResponse((global::ModerationAPI.VoiceSessionStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.VoiceSessionStarted?(GetStreamResponse @this) => @this.SessionStarted;

        /// <summary>
        /// 
        /// </summary>
        public GetStreamResponse(global::ModerationAPI.VoiceSessionStarted? value)
        {
            SessionStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetStreamResponse FromSessionStarted(global::ModerationAPI.VoiceSessionStarted? value) => new GetStreamResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetStreamResponse(global::ModerationAPI.VoiceUtteranceFinal value) => new GetStreamResponse((global::ModerationAPI.VoiceUtteranceFinal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.VoiceUtteranceFinal?(GetStreamResponse @this) => @this.UtteranceFinal;

        /// <summary>
        /// 
        /// </summary>
        public GetStreamResponse(global::ModerationAPI.VoiceUtteranceFinal? value)
        {
            UtteranceFinal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetStreamResponse FromUtteranceFinal(global::ModerationAPI.VoiceUtteranceFinal? value) => new GetStreamResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetStreamResponse(global::ModerationAPI.VoiceSessionEnded value) => new GetStreamResponse((global::ModerationAPI.VoiceSessionEnded?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.VoiceSessionEnded?(GetStreamResponse @this) => @this.SessionEnded;

        /// <summary>
        /// 
        /// </summary>
        public GetStreamResponse(global::ModerationAPI.VoiceSessionEnded? value)
        {
            SessionEnded = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetStreamResponse FromSessionEnded(global::ModerationAPI.VoiceSessionEnded? value) => new GetStreamResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public GetStreamResponse(
            global::ModerationAPI.GetStreamResponseDiscriminatorEvent? @event,
            global::ModerationAPI.VoiceSessionStarted? sessionStarted,
            global::ModerationAPI.VoiceUtteranceFinal? utteranceFinal,
            global::ModerationAPI.VoiceSessionEnded? sessionEnded
            )
        {
            Event = @event;

            SessionStarted = sessionStarted;
            UtteranceFinal = utteranceFinal;
            SessionEnded = sessionEnded;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SessionEnded as object ??
            UtteranceFinal as object ??
            SessionStarted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionStarted?.ToString() ??
            UtteranceFinal?.ToString() ??
            SessionEnded?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionStarted && !IsUtteranceFinal && !IsSessionEnded || !IsSessionStarted && IsUtteranceFinal && !IsSessionEnded || !IsSessionStarted && !IsUtteranceFinal && IsSessionEnded;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ModerationAPI.VoiceSessionStarted, TResult>? sessionStarted = null,
            global::System.Func<global::ModerationAPI.VoiceUtteranceFinal, TResult>? utteranceFinal = null,
            global::System.Func<global::ModerationAPI.VoiceSessionEnded, TResult>? sessionEnded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStarted && sessionStarted != null)
            {
                return sessionStarted(SessionStarted!);
            }
            else if (IsUtteranceFinal && utteranceFinal != null)
            {
                return utteranceFinal(UtteranceFinal!);
            }
            else if (IsSessionEnded && sessionEnded != null)
            {
                return sessionEnded(SessionEnded!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ModerationAPI.VoiceSessionStarted>? sessionStarted = null,

            global::System.Action<global::ModerationAPI.VoiceUtteranceFinal>? utteranceFinal = null,

            global::System.Action<global::ModerationAPI.VoiceSessionEnded>? sessionEnded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStarted)
            {
                sessionStarted?.Invoke(SessionStarted!);
            }
            else if (IsUtteranceFinal)
            {
                utteranceFinal?.Invoke(UtteranceFinal!);
            }
            else if (IsSessionEnded)
            {
                sessionEnded?.Invoke(SessionEnded!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ModerationAPI.VoiceSessionStarted>? sessionStarted = null,
            global::System.Action<global::ModerationAPI.VoiceUtteranceFinal>? utteranceFinal = null,
            global::System.Action<global::ModerationAPI.VoiceSessionEnded>? sessionEnded = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStarted)
            {
                sessionStarted?.Invoke(SessionStarted!);
            }
            else if (IsUtteranceFinal)
            {
                utteranceFinal?.Invoke(UtteranceFinal!);
            }
            else if (IsSessionEnded)
            {
                sessionEnded?.Invoke(SessionEnded!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionStarted,
                typeof(global::ModerationAPI.VoiceSessionStarted),
                UtteranceFinal,
                typeof(global::ModerationAPI.VoiceUtteranceFinal),
                SessionEnded,
                typeof(global::ModerationAPI.VoiceSessionEnded),
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
        public bool Equals(GetStreamResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.VoiceSessionStarted?>.Default.Equals(SessionStarted, other.SessionStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.VoiceUtteranceFinal?>.Default.Equals(UtteranceFinal, other.UtteranceFinal) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.VoiceSessionEnded?>.Default.Equals(SessionEnded, other.SessionEnded) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetStreamResponse obj1, GetStreamResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetStreamResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetStreamResponse obj1, GetStreamResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetStreamResponse o && Equals(o);
        }
    }
}
