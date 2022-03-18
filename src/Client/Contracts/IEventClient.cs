using Armut.Iterable.Client.Core.Responses;
using Armut.Iterable.Client.Models.EventModels;
using System.Threading.Tasks;

namespace Armut.Iterable.Client.Contracts
{
    public interface IEventClient
    {
        Task<ApiResponse<SubscribeUserResponse>> TrackAsync(EventTrackRequest model);
        Task<ApiResponse<SubscribeUserResponse>> TrackInAppOpenAsync(InAppConsumeRequest model);
        Task<ApiResponse<SubscribeUserResponse>> TrackInAppClickAsync(EventTrackInAppClickRequest model);
        Task<ApiResponse<SubscribeUserResponse>> TrackInAppDeliveryAsync(EventTrackInAppDeliveryRequest model);
        Task<ApiResponse<SubscribeUserResponse>> TrackInAppCloseAsync(EventTrackInAppCloseRequest model);
        Task<ApiResponse<SubscribeUserResponse>> InAppConsumeAsync(InAppConsumeRequest model);

    }
}