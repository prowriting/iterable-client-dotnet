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

        public async Task<ApiResponse<SubscribeUserResponse>> TrackAsync(EventTrackRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<SubscribeUserResponse>("/api/events/track", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<SubscribeUserResponse>> TrackInAppOpenAsync(InAppConsumeRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));
            
            return await _client.PostAsync<SubscribeUserResponse>("/api/events/trackInAppOpen", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<SubscribeUserResponse>> TrackInAppClickAsync(EventTrackInAppClickRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<SubscribeUserResponse>("/api/events/trackInAppClick", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<SubscribeUserResponse>> TrackInAppDeliveryAsync(EventTrackInAppDeliveryRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<SubscribeUserResponse>("/api/events/trackInAppDelivery", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<SubscribeUserResponse>> TrackInAppCloseAsync(EventTrackInAppCloseRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<SubscribeUserResponse>("/api/events/trackInAppClose", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<SubscribeUserResponse>> InAppConsumeAsync(InAppConsumeRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<SubscribeUserResponse>("/api/events/inAppConsume", model).ConfigureAwait(false);
        }

    }
}