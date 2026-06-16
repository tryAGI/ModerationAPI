#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ModerationAPI
{
    /// <summary>
    /// Discriminated union of every v2 webhook event. Switch on `type` to narrow to a specific event shape.
    /// </summary>
    public readonly partial struct WebhookEvent : global::System.IEquatable<WebhookEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.WebhookEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"author.blocked","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"act_block_123","key":"block","name":"Block author","value":null,"created_at":"2026-05-08T12:38:00.000Z","author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"blocked","trust_level":{"level":-1,"manual":false},"block":{"until":null,"reason":"Repeated spam violations"},"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.AuthorBlockedEvent? AuthorBlocked { get; init; }
#else
        public global::ModerationAPI.AuthorBlockedEvent? AuthorBlocked { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthorBlocked))]
#endif
        public bool IsAuthorBlocked => AuthorBlocked != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAuthorBlocked(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.AuthorBlockedEvent? value)
        {
            value = AuthorBlocked;
            return IsAuthorBlocked;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.AuthorBlockedEvent PickAuthorBlocked() => IsAuthorBlocked
            ? AuthorBlocked!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AuthorBlocked' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"author.unblocked","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"act_unblock_789","key":"auto_unblock","name":"Auto unblock","value":null,"created_at":"2026-05-09T12:39:00.000Z","author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"enabled","trust_level":{"level":0,"manual":false},"block":null,"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.AuthorUnblockedEvent? AuthorUnblocked { get; init; }
#else
        public global::ModerationAPI.AuthorUnblockedEvent? AuthorUnblocked { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthorUnblocked))]
#endif
        public bool IsAuthorUnblocked => AuthorUnblocked != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAuthorUnblocked(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.AuthorUnblockedEvent? value)
        {
            value = AuthorUnblocked;
            return IsAuthorUnblocked;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.AuthorUnblockedEvent PickAuthorUnblocked() => IsAuthorUnblocked
            ? AuthorUnblocked!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AuthorUnblocked' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"author.suspended","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"act_suspend_456","key":"suspend_24h","name":"Suspend (24h)","value":"24h","created_at":"2026-05-08T12:39:00.000Z","author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"suspended","trust_level":{"level":0,"manual":false},"block":{"until":1746878400000,"reason":"Cooling-off period"},"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.AuthorSuspendedEvent? AuthorSuspended { get; init; }
#else
        public global::ModerationAPI.AuthorSuspendedEvent? AuthorSuspended { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthorSuspended))]
#endif
        public bool IsAuthorSuspended => AuthorSuspended != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAuthorSuspended(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.AuthorSuspendedEvent? value)
        {
            value = AuthorSuspended;
            return IsAuthorSuspended;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.AuthorSuspendedEvent PickAuthorSuspended() => IsAuthorSuspended
            ? AuthorSuspended!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AuthorSuspended' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"author.updated","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"enabled","trust_level":{"level":1,"manual":false},"block":null,"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.AuthorUpdatedEvent? AuthorUpdated { get; init; }
#else
        public global::ModerationAPI.AuthorUpdatedEvent? AuthorUpdated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthorUpdated))]
#endif
        public bool IsAuthorUpdated => AuthorUpdated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAuthorUpdated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.AuthorUpdatedEvent? value)
        {
            value = AuthorUpdated;
            return IsAuthorUpdated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.AuthorUpdatedEvent PickAuthorUpdated() => IsAuthorUpdated
            ? AuthorUpdated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AuthorUpdated' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"author.trust_level_changed","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"enabled","trust_level":{"level":3,"manual":true},"block":null,"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.AuthorTrustLevelChangedEvent? AuthorTrustLevelChanged { get; init; }
#else
        public global::ModerationAPI.AuthorTrustLevelChangedEvent? AuthorTrustLevelChanged { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthorTrustLevelChanged))]
#endif
        public bool IsAuthorTrustLevelChanged => AuthorTrustLevelChanged != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAuthorTrustLevelChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.AuthorTrustLevelChangedEvent? value)
        {
            value = AuthorTrustLevelChanged;
            return IsAuthorTrustLevelChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.AuthorTrustLevelChangedEvent PickAuthorTrustLevelChanged() => IsAuthorTrustLevelChanged
            ? AuthorTrustLevelChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AuthorTrustLevelChanged' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"author.action","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"act_warn_111","key":"send_warning","name":"Send warning email","value":"violation_notice","created_at":"2026-05-08T12:42:00.000Z","author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"enabled","trust_level":{"level":1,"manual":false},"block":null,"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.AuthorActionEvent? AuthorAction { get; init; }
#else
        public global::ModerationAPI.AuthorActionEvent? AuthorAction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthorAction))]
#endif
        public bool IsAuthorAction => AuthorAction != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAuthorAction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.AuthorActionEvent? value)
        {
            value = AuthorAction;
            return IsAuthorAction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.AuthorActionEvent PickAuthorAction() => IsAuthorAction
            ? AuthorAction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AuthorAction' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"queue_item.resolved","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"item":{"id":"item_xyz789","flagged":true,"labels":[{"label":"spam/SPAM","score":0.94,"flagged":true,"manual":false}],"language":"en","content":{"type":"text","text":"Buy crypto now!"},"timestamp":"2026-05-08T12:34:56.789Z","metadata":null,"conversation_id":null,"author_id":"user-555","channel_key":null,"meta_type":"comment"},"author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"blocked","trust_level":{"level":-1,"manual":false},"block":{"until":null,"reason":"Repeated spam violations"},"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}},"queue":{"id":"que_abc123"}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.QueueItemCompletedEvent? QueueItemResolved { get; init; }
#else
        public global::ModerationAPI.QueueItemCompletedEvent? QueueItemResolved { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueueItemResolved))]
#endif
        public bool IsQueueItemResolved => QueueItemResolved != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickQueueItemResolved(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.QueueItemCompletedEvent? value)
        {
            value = QueueItemResolved;
            return IsQueueItemResolved;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.QueueItemCompletedEvent PickQueueItemResolved() => IsQueueItemResolved
            ? QueueItemResolved!
            : throw new global::System.InvalidOperationException($"Expected union variant 'QueueItemResolved' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"queue_item.action","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"act_99999","key":"shadow_ban","name":"Shadow ban","value":"24h","created_at":"2026-05-08T12:36:00.000Z","queue":{"id":"que_abc123"},"item":{"id":"item_xyz791","flagged":true,"labels":[{"label":"spam/SPAM","score":0.94,"flagged":true,"manual":false}],"language":"en","content":{"type":"text","text":"Buy crypto now!"},"timestamp":"2026-05-08T12:34:56.789Z","metadata":null,"conversation_id":null,"author_id":"user-555","channel_key":null,"meta_type":"comment"},"author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"enabled","trust_level":{"level":1,"manual":false},"block":null,"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.QueueItemActionEvent? QueueItemAction { get; init; }
#else
        public global::ModerationAPI.QueueItemActionEvent? QueueItemAction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueueItemAction))]
#endif
        public bool IsQueueItemAction => QueueItemAction != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickQueueItemAction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.QueueItemActionEvent? value)
        {
            value = QueueItemAction;
            return IsQueueItemAction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.QueueItemActionEvent PickQueueItemAction() => IsQueueItemAction
            ? QueueItemAction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'QueueItemAction' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"queue_item.rejected","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"act_67890","key":"reject","name":"Reject","value":"spam","created_at":"2026-05-08T12:34:56.789Z","queue":{"id":"que_abc123"},"item":{"id":"item_xyz789","flagged":true,"labels":[{"label":"spam/SPAM","score":0.94,"flagged":true,"manual":false}],"language":"en","content":{"type":"text","text":"Buy crypto now!"},"timestamp":"2026-05-08T12:34:56.789Z","metadata":null,"conversation_id":null,"author_id":"user-555","channel_key":null,"meta_type":"comment"},"author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"enabled","trust_level":{"level":1,"manual":false},"block":null,"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.QueueItemRejectedEvent? QueueItemRejected { get; init; }
#else
        public global::ModerationAPI.QueueItemRejectedEvent? QueueItemRejected { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueueItemRejected))]
#endif
        public bool IsQueueItemRejected => QueueItemRejected != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickQueueItemRejected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.QueueItemRejectedEvent? value)
        {
            value = QueueItemRejected;
            return IsQueueItemRejected;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.QueueItemRejectedEvent PickQueueItemRejected() => IsQueueItemRejected
            ? QueueItemRejected!
            : throw new global::System.InvalidOperationException($"Expected union variant 'QueueItemRejected' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"evt_clx9f2k0a0001abcd1234","type":"queue_item.allowed","api_version":"v2","created":"2026-05-08T12:34:56.789Z","data":{"object":{"id":"act_11111","key":"allow","name":"Allow","value":null,"created_at":"2026-05-08T12:35:10.123Z","queue":{"id":"que_abc123"},"item":{"id":"item_xyz790","flagged":false,"labels":[],"language":"en","content":{"type":"text","text":"Buy crypto now!"},"timestamp":"2026-05-08T12:34:56.789Z","metadata":null,"conversation_id":null,"author_id":"user-555","channel_key":null,"meta_type":"comment"},"author":{"id":"auth_555","external_id":"user-555","profile_picture":null,"external_link":null,"name":"Jane Doe","email":"jane@example.com","company":null,"first_seen":1746792000000,"last_seen":1746792000000,"last_incident":null,"status":"enabled","trust_level":{"level":1,"manual":false},"block":null,"risk_evaluation":null,"metrics":{"total_content":42,"flagged_content":7,"average_sentiment":-0.1},"metadata":{}}}}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ModerationAPI.QueueItemAllowedEvent? QueueItemAllowed { get; init; }
#else
        public global::ModerationAPI.QueueItemAllowedEvent? QueueItemAllowed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QueueItemAllowed))]
#endif
        public bool IsQueueItemAllowed => QueueItemAllowed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickQueueItemAllowed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ModerationAPI.QueueItemAllowedEvent? value)
        {
            value = QueueItemAllowed;
            return IsQueueItemAllowed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ModerationAPI.QueueItemAllowedEvent PickQueueItemAllowed() => IsQueueItemAllowed
            ? QueueItemAllowed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'QueueItemAllowed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.AuthorBlockedEvent value) => new WebhookEvent((global::ModerationAPI.AuthorBlockedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.AuthorBlockedEvent?(WebhookEvent @this) => @this.AuthorBlocked;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.AuthorBlockedEvent? value)
        {
            AuthorBlocked = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromAuthorBlocked(global::ModerationAPI.AuthorBlockedEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.AuthorUnblockedEvent value) => new WebhookEvent((global::ModerationAPI.AuthorUnblockedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.AuthorUnblockedEvent?(WebhookEvent @this) => @this.AuthorUnblocked;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.AuthorUnblockedEvent? value)
        {
            AuthorUnblocked = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromAuthorUnblocked(global::ModerationAPI.AuthorUnblockedEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.AuthorSuspendedEvent value) => new WebhookEvent((global::ModerationAPI.AuthorSuspendedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.AuthorSuspendedEvent?(WebhookEvent @this) => @this.AuthorSuspended;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.AuthorSuspendedEvent? value)
        {
            AuthorSuspended = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromAuthorSuspended(global::ModerationAPI.AuthorSuspendedEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.AuthorUpdatedEvent value) => new WebhookEvent((global::ModerationAPI.AuthorUpdatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.AuthorUpdatedEvent?(WebhookEvent @this) => @this.AuthorUpdated;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.AuthorUpdatedEvent? value)
        {
            AuthorUpdated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromAuthorUpdated(global::ModerationAPI.AuthorUpdatedEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.AuthorTrustLevelChangedEvent value) => new WebhookEvent((global::ModerationAPI.AuthorTrustLevelChangedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.AuthorTrustLevelChangedEvent?(WebhookEvent @this) => @this.AuthorTrustLevelChanged;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.AuthorTrustLevelChangedEvent? value)
        {
            AuthorTrustLevelChanged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromAuthorTrustLevelChanged(global::ModerationAPI.AuthorTrustLevelChangedEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.AuthorActionEvent value) => new WebhookEvent((global::ModerationAPI.AuthorActionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.AuthorActionEvent?(WebhookEvent @this) => @this.AuthorAction;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.AuthorActionEvent? value)
        {
            AuthorAction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromAuthorAction(global::ModerationAPI.AuthorActionEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.QueueItemCompletedEvent value) => new WebhookEvent((global::ModerationAPI.QueueItemCompletedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.QueueItemCompletedEvent?(WebhookEvent @this) => @this.QueueItemResolved;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.QueueItemCompletedEvent? value)
        {
            QueueItemResolved = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromQueueItemResolved(global::ModerationAPI.QueueItemCompletedEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.QueueItemActionEvent value) => new WebhookEvent((global::ModerationAPI.QueueItemActionEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.QueueItemActionEvent?(WebhookEvent @this) => @this.QueueItemAction;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.QueueItemActionEvent? value)
        {
            QueueItemAction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromQueueItemAction(global::ModerationAPI.QueueItemActionEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.QueueItemRejectedEvent value) => new WebhookEvent((global::ModerationAPI.QueueItemRejectedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.QueueItemRejectedEvent?(WebhookEvent @this) => @this.QueueItemRejected;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.QueueItemRejectedEvent? value)
        {
            QueueItemRejected = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromQueueItemRejected(global::ModerationAPI.QueueItemRejectedEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookEvent(global::ModerationAPI.QueueItemAllowedEvent value) => new WebhookEvent((global::ModerationAPI.QueueItemAllowedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ModerationAPI.QueueItemAllowedEvent?(WebhookEvent @this) => @this.QueueItemAllowed;

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(global::ModerationAPI.QueueItemAllowedEvent? value)
        {
            QueueItemAllowed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookEvent FromQueueItemAllowed(global::ModerationAPI.QueueItemAllowedEvent? value) => new WebhookEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public WebhookEvent(
            global::ModerationAPI.WebhookEventDiscriminatorType? type,
            global::ModerationAPI.AuthorBlockedEvent? authorBlocked,
            global::ModerationAPI.AuthorUnblockedEvent? authorUnblocked,
            global::ModerationAPI.AuthorSuspendedEvent? authorSuspended,
            global::ModerationAPI.AuthorUpdatedEvent? authorUpdated,
            global::ModerationAPI.AuthorTrustLevelChangedEvent? authorTrustLevelChanged,
            global::ModerationAPI.AuthorActionEvent? authorAction,
            global::ModerationAPI.QueueItemCompletedEvent? queueItemResolved,
            global::ModerationAPI.QueueItemActionEvent? queueItemAction,
            global::ModerationAPI.QueueItemRejectedEvent? queueItemRejected,
            global::ModerationAPI.QueueItemAllowedEvent? queueItemAllowed
            )
        {
            Type = type;

            AuthorBlocked = authorBlocked;
            AuthorUnblocked = authorUnblocked;
            AuthorSuspended = authorSuspended;
            AuthorUpdated = authorUpdated;
            AuthorTrustLevelChanged = authorTrustLevelChanged;
            AuthorAction = authorAction;
            QueueItemResolved = queueItemResolved;
            QueueItemAction = queueItemAction;
            QueueItemRejected = queueItemRejected;
            QueueItemAllowed = queueItemAllowed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            QueueItemAllowed as object ??
            QueueItemRejected as object ??
            QueueItemAction as object ??
            QueueItemResolved as object ??
            AuthorAction as object ??
            AuthorTrustLevelChanged as object ??
            AuthorUpdated as object ??
            AuthorSuspended as object ??
            AuthorUnblocked as object ??
            AuthorBlocked as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AuthorBlocked?.ToString() ??
            AuthorUnblocked?.ToString() ??
            AuthorSuspended?.ToString() ??
            AuthorUpdated?.ToString() ??
            AuthorTrustLevelChanged?.ToString() ??
            AuthorAction?.ToString() ??
            QueueItemResolved?.ToString() ??
            QueueItemAction?.ToString() ??
            QueueItemRejected?.ToString() ??
            QueueItemAllowed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAuthorBlocked && !IsAuthorUnblocked && !IsAuthorSuspended && !IsAuthorUpdated && !IsAuthorTrustLevelChanged && !IsAuthorAction && !IsQueueItemResolved && !IsQueueItemAction && !IsQueueItemRejected && !IsQueueItemAllowed || !IsAuthorBlocked && IsAuthorUnblocked && !IsAuthorSuspended && !IsAuthorUpdated && !IsAuthorTrustLevelChanged && !IsAuthorAction && !IsQueueItemResolved && !IsQueueItemAction && !IsQueueItemRejected && !IsQueueItemAllowed || !IsAuthorBlocked && !IsAuthorUnblocked && IsAuthorSuspended && !IsAuthorUpdated && !IsAuthorTrustLevelChanged && !IsAuthorAction && !IsQueueItemResolved && !IsQueueItemAction && !IsQueueItemRejected && !IsQueueItemAllowed || !IsAuthorBlocked && !IsAuthorUnblocked && !IsAuthorSuspended && IsAuthorUpdated && !IsAuthorTrustLevelChanged && !IsAuthorAction && !IsQueueItemResolved && !IsQueueItemAction && !IsQueueItemRejected && !IsQueueItemAllowed || !IsAuthorBlocked && !IsAuthorUnblocked && !IsAuthorSuspended && !IsAuthorUpdated && IsAuthorTrustLevelChanged && !IsAuthorAction && !IsQueueItemResolved && !IsQueueItemAction && !IsQueueItemRejected && !IsQueueItemAllowed || !IsAuthorBlocked && !IsAuthorUnblocked && !IsAuthorSuspended && !IsAuthorUpdated && !IsAuthorTrustLevelChanged && IsAuthorAction && !IsQueueItemResolved && !IsQueueItemAction && !IsQueueItemRejected && !IsQueueItemAllowed || !IsAuthorBlocked && !IsAuthorUnblocked && !IsAuthorSuspended && !IsAuthorUpdated && !IsAuthorTrustLevelChanged && !IsAuthorAction && IsQueueItemResolved && !IsQueueItemAction && !IsQueueItemRejected && !IsQueueItemAllowed || !IsAuthorBlocked && !IsAuthorUnblocked && !IsAuthorSuspended && !IsAuthorUpdated && !IsAuthorTrustLevelChanged && !IsAuthorAction && !IsQueueItemResolved && IsQueueItemAction && !IsQueueItemRejected && !IsQueueItemAllowed || !IsAuthorBlocked && !IsAuthorUnblocked && !IsAuthorSuspended && !IsAuthorUpdated && !IsAuthorTrustLevelChanged && !IsAuthorAction && !IsQueueItemResolved && !IsQueueItemAction && IsQueueItemRejected && !IsQueueItemAllowed || !IsAuthorBlocked && !IsAuthorUnblocked && !IsAuthorSuspended && !IsAuthorUpdated && !IsAuthorTrustLevelChanged && !IsAuthorAction && !IsQueueItemResolved && !IsQueueItemAction && !IsQueueItemRejected && IsQueueItemAllowed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ModerationAPI.AuthorBlockedEvent, TResult>? authorBlocked = null,
            global::System.Func<global::ModerationAPI.AuthorUnblockedEvent, TResult>? authorUnblocked = null,
            global::System.Func<global::ModerationAPI.AuthorSuspendedEvent, TResult>? authorSuspended = null,
            global::System.Func<global::ModerationAPI.AuthorUpdatedEvent, TResult>? authorUpdated = null,
            global::System.Func<global::ModerationAPI.AuthorTrustLevelChangedEvent, TResult>? authorTrustLevelChanged = null,
            global::System.Func<global::ModerationAPI.AuthorActionEvent, TResult>? authorAction = null,
            global::System.Func<global::ModerationAPI.QueueItemCompletedEvent, TResult>? queueItemResolved = null,
            global::System.Func<global::ModerationAPI.QueueItemActionEvent, TResult>? queueItemAction = null,
            global::System.Func<global::ModerationAPI.QueueItemRejectedEvent, TResult>? queueItemRejected = null,
            global::System.Func<global::ModerationAPI.QueueItemAllowedEvent, TResult>? queueItemAllowed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuthorBlocked && authorBlocked != null)
            {
                return authorBlocked(AuthorBlocked!);
            }
            else if (IsAuthorUnblocked && authorUnblocked != null)
            {
                return authorUnblocked(AuthorUnblocked!);
            }
            else if (IsAuthorSuspended && authorSuspended != null)
            {
                return authorSuspended(AuthorSuspended!);
            }
            else if (IsAuthorUpdated && authorUpdated != null)
            {
                return authorUpdated(AuthorUpdated!);
            }
            else if (IsAuthorTrustLevelChanged && authorTrustLevelChanged != null)
            {
                return authorTrustLevelChanged(AuthorTrustLevelChanged!);
            }
            else if (IsAuthorAction && authorAction != null)
            {
                return authorAction(AuthorAction!);
            }
            else if (IsQueueItemResolved && queueItemResolved != null)
            {
                return queueItemResolved(QueueItemResolved!);
            }
            else if (IsQueueItemAction && queueItemAction != null)
            {
                return queueItemAction(QueueItemAction!);
            }
            else if (IsQueueItemRejected && queueItemRejected != null)
            {
                return queueItemRejected(QueueItemRejected!);
            }
            else if (IsQueueItemAllowed && queueItemAllowed != null)
            {
                return queueItemAllowed(QueueItemAllowed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ModerationAPI.AuthorBlockedEvent>? authorBlocked = null,

            global::System.Action<global::ModerationAPI.AuthorUnblockedEvent>? authorUnblocked = null,

            global::System.Action<global::ModerationAPI.AuthorSuspendedEvent>? authorSuspended = null,

            global::System.Action<global::ModerationAPI.AuthorUpdatedEvent>? authorUpdated = null,

            global::System.Action<global::ModerationAPI.AuthorTrustLevelChangedEvent>? authorTrustLevelChanged = null,

            global::System.Action<global::ModerationAPI.AuthorActionEvent>? authorAction = null,

            global::System.Action<global::ModerationAPI.QueueItemCompletedEvent>? queueItemResolved = null,

            global::System.Action<global::ModerationAPI.QueueItemActionEvent>? queueItemAction = null,

            global::System.Action<global::ModerationAPI.QueueItemRejectedEvent>? queueItemRejected = null,

            global::System.Action<global::ModerationAPI.QueueItemAllowedEvent>? queueItemAllowed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuthorBlocked)
            {
                authorBlocked?.Invoke(AuthorBlocked!);
            }
            else if (IsAuthorUnblocked)
            {
                authorUnblocked?.Invoke(AuthorUnblocked!);
            }
            else if (IsAuthorSuspended)
            {
                authorSuspended?.Invoke(AuthorSuspended!);
            }
            else if (IsAuthorUpdated)
            {
                authorUpdated?.Invoke(AuthorUpdated!);
            }
            else if (IsAuthorTrustLevelChanged)
            {
                authorTrustLevelChanged?.Invoke(AuthorTrustLevelChanged!);
            }
            else if (IsAuthorAction)
            {
                authorAction?.Invoke(AuthorAction!);
            }
            else if (IsQueueItemResolved)
            {
                queueItemResolved?.Invoke(QueueItemResolved!);
            }
            else if (IsQueueItemAction)
            {
                queueItemAction?.Invoke(QueueItemAction!);
            }
            else if (IsQueueItemRejected)
            {
                queueItemRejected?.Invoke(QueueItemRejected!);
            }
            else if (IsQueueItemAllowed)
            {
                queueItemAllowed?.Invoke(QueueItemAllowed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ModerationAPI.AuthorBlockedEvent>? authorBlocked = null,
            global::System.Action<global::ModerationAPI.AuthorUnblockedEvent>? authorUnblocked = null,
            global::System.Action<global::ModerationAPI.AuthorSuspendedEvent>? authorSuspended = null,
            global::System.Action<global::ModerationAPI.AuthorUpdatedEvent>? authorUpdated = null,
            global::System.Action<global::ModerationAPI.AuthorTrustLevelChangedEvent>? authorTrustLevelChanged = null,
            global::System.Action<global::ModerationAPI.AuthorActionEvent>? authorAction = null,
            global::System.Action<global::ModerationAPI.QueueItemCompletedEvent>? queueItemResolved = null,
            global::System.Action<global::ModerationAPI.QueueItemActionEvent>? queueItemAction = null,
            global::System.Action<global::ModerationAPI.QueueItemRejectedEvent>? queueItemRejected = null,
            global::System.Action<global::ModerationAPI.QueueItemAllowedEvent>? queueItemAllowed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuthorBlocked)
            {
                authorBlocked?.Invoke(AuthorBlocked!);
            }
            else if (IsAuthorUnblocked)
            {
                authorUnblocked?.Invoke(AuthorUnblocked!);
            }
            else if (IsAuthorSuspended)
            {
                authorSuspended?.Invoke(AuthorSuspended!);
            }
            else if (IsAuthorUpdated)
            {
                authorUpdated?.Invoke(AuthorUpdated!);
            }
            else if (IsAuthorTrustLevelChanged)
            {
                authorTrustLevelChanged?.Invoke(AuthorTrustLevelChanged!);
            }
            else if (IsAuthorAction)
            {
                authorAction?.Invoke(AuthorAction!);
            }
            else if (IsQueueItemResolved)
            {
                queueItemResolved?.Invoke(QueueItemResolved!);
            }
            else if (IsQueueItemAction)
            {
                queueItemAction?.Invoke(QueueItemAction!);
            }
            else if (IsQueueItemRejected)
            {
                queueItemRejected?.Invoke(QueueItemRejected!);
            }
            else if (IsQueueItemAllowed)
            {
                queueItemAllowed?.Invoke(QueueItemAllowed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AuthorBlocked,
                typeof(global::ModerationAPI.AuthorBlockedEvent),
                AuthorUnblocked,
                typeof(global::ModerationAPI.AuthorUnblockedEvent),
                AuthorSuspended,
                typeof(global::ModerationAPI.AuthorSuspendedEvent),
                AuthorUpdated,
                typeof(global::ModerationAPI.AuthorUpdatedEvent),
                AuthorTrustLevelChanged,
                typeof(global::ModerationAPI.AuthorTrustLevelChangedEvent),
                AuthorAction,
                typeof(global::ModerationAPI.AuthorActionEvent),
                QueueItemResolved,
                typeof(global::ModerationAPI.QueueItemCompletedEvent),
                QueueItemAction,
                typeof(global::ModerationAPI.QueueItemActionEvent),
                QueueItemRejected,
                typeof(global::ModerationAPI.QueueItemRejectedEvent),
                QueueItemAllowed,
                typeof(global::ModerationAPI.QueueItemAllowedEvent),
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
        public bool Equals(WebhookEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.AuthorBlockedEvent?>.Default.Equals(AuthorBlocked, other.AuthorBlocked) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.AuthorUnblockedEvent?>.Default.Equals(AuthorUnblocked, other.AuthorUnblocked) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.AuthorSuspendedEvent?>.Default.Equals(AuthorSuspended, other.AuthorSuspended) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.AuthorUpdatedEvent?>.Default.Equals(AuthorUpdated, other.AuthorUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.AuthorTrustLevelChangedEvent?>.Default.Equals(AuthorTrustLevelChanged, other.AuthorTrustLevelChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.AuthorActionEvent?>.Default.Equals(AuthorAction, other.AuthorAction) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.QueueItemCompletedEvent?>.Default.Equals(QueueItemResolved, other.QueueItemResolved) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.QueueItemActionEvent?>.Default.Equals(QueueItemAction, other.QueueItemAction) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.QueueItemRejectedEvent?>.Default.Equals(QueueItemRejected, other.QueueItemRejected) &&
                global::System.Collections.Generic.EqualityComparer<global::ModerationAPI.QueueItemAllowedEvent?>.Default.Equals(QueueItemAllowed, other.QueueItemAllowed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebhookEvent obj1, WebhookEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebhookEvent obj1, WebhookEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookEvent o && Equals(o);
        }
    }
}
