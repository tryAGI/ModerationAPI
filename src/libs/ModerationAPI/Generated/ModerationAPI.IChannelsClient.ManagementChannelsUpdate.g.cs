#nullable enable

namespace ModerationAPI
{
    public partial interface IChannelsClient
    {
        /// <summary>
        /// Update a channel<br/>
        /// Update a channel. Fields you leave out keep their value. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.Channel> ManagementChannelsUpdateAsync(
            string id,

            global::ModerationAPI.ManagementChannelsUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a channel<br/>
        /// Update a channel. Fields you leave out keep their value. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel to update.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ModerationAPI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.AutoSDKHttpResponse<global::ModerationAPI.Channel>> ManagementChannelsUpdateAsResponseAsync(
            string id,

            global::ModerationAPI.ManagementChannelsUpdateRequest request,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a channel<br/>
        /// Update a channel. Fields you leave out keep their value. Needs the `channels:write` permission.
        /// </summary>
        /// <param name="id">
        /// The ID of the channel to update.
        /// </param>
        /// <param name="name">
        /// The channel's name.
        /// </param>
        /// <param name="key">
        /// The key you pass as `channel` when you moderate content. Changing it breaks integrations that send the old key.
        /// </param>
        /// <param name="description">
        /// The channel's description.
        /// </param>
        /// <param name="contentType">
        /// The kind of content the channel moderates.
        /// </param>
        /// <param name="flaggingMode">
        /// `ACTIVE` flags content. `DRY_RUN` evaluates content without flagging it.
        /// </param>
        /// <param name="contextEnabled">
        /// Whether earlier messages in the conversation are read when moderating a message.
        /// </param>
        /// <param name="enableImageModeration">
        /// Whether images are moderated.
        /// </param>
        /// <param name="enableVideoModeration">
        /// Whether videos are moderated.
        /// </param>
        /// <param name="enableAudioModeration">
        /// Whether audio is moderated.
        /// </param>
        /// <param name="enableVoiceModeration">
        /// Whether real-time voice streams are moderated.
        /// </param>
        /// <param name="includeTranscriptInResponse">
        /// Whether audio and video transcripts are returned in responses.
        /// </param>
        /// <param name="transcriptionQuality">
        /// Trade-off between transcription speed and accuracy.
        /// </param>
        /// <param name="unicodeSpoofDetectionEnabled">
        /// Whether look-alike Unicode characters are normalized before moderation.
        /// </param>
        /// <param name="frameCaptureInterval">
        /// Seconds between frames captured from a video.
        /// </param>
        /// <param name="maxFramesPerVideo">
        /// The most frames moderated per video.
        /// </param>
        /// <param name="spreadFrames">
        /// Whether frames are spread evenly across the whole video.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ModerationAPI.Channel> ManagementChannelsUpdateAsync(
            string id,
            string? name = default,
            string? key = default,
            string? description = default,
            global::ModerationAPI.ManagementChannelsUpdateRequestContentType? contentType = default,
            global::ModerationAPI.ManagementChannelsUpdateRequestFlaggingMode? flaggingMode = default,
            bool? contextEnabled = default,
            bool? enableImageModeration = default,
            bool? enableVideoModeration = default,
            bool? enableAudioModeration = default,
            bool? enableVoiceModeration = default,
            bool? includeTranscriptInResponse = default,
            global::ModerationAPI.ManagementChannelsUpdateRequestTranscriptionQuality? transcriptionQuality = default,
            bool? unicodeSpoofDetectionEnabled = default,
            double? frameCaptureInterval = default,
            int? maxFramesPerVideo = default,
            bool? spreadFrames = default,
            global::ModerationAPI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}