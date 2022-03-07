using System.Threading.Tasks;
using Armut.Iterable.Client.Contracts;
using Armut.Iterable.Client.Core;
using Armut.Iterable.Client.Core.Responses;
using Armut.Iterable.Client.Models.EventModels;

namespace Armut.Iterable.Client
{
    public class EventClient : IEventClient
    {
        private readonly IRestClient _client;

        public EventClient(IRestClient client)
        {
            _client = client;
        }

        public async Task<ApiResponse<EventTrackResponse>> TrackAsync(EventTrackRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<EventTrackResponse>("/api/events/track", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<EventTrackResponse>> TrackInAppOpenAsync(InAppConsumeRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));
            
            return await _client.PostAsync<EventTrackResponse>("/api/events/trackInAppOpen", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<EventTrackResponse>> TrackInAppClickAsync(EventTrackInAppClickRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<EventTrackResponse>("/api/events/trackInAppClick", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<EventTrackResponse>> TrackInAppDeliveryAsync(EventTrackInAppDeliveryRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<EventTrackResponse>("/api/events/trackInAppDelivery", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<EventTrackResponse>> TrackInAppCloseAsync(EventTrackInAppCloseRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<EventTrackResponse>("/api/events/trackInAppClose", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<EventTrackResponse>> InAppConsumeAsync(InAppConsumeRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<EventTrackResponse>("/api/events/inAppConsume", model).ConfigureAwait(false);
        }

    }
}