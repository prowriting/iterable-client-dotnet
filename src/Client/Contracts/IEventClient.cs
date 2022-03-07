using Armut.Iterable.Client.Core.Responses;
using Armut.Iterable.Client.Models.EventModels;
using System.Threading.Tasks;

namespace Armut.Iterable.Client.Contracts
{
    public interface IEventClient
    {
        Task<ApiResponse<EventTrackResponse>> TrackAsync(EventTrackRequest model);
        Task<ApiResponse<EventTrackResponse>> TrackInAppOpenAsync(InAppConsumeRequest model);
        Task<ApiResponse<EventTrackResponse>> TrackInAppClickAsync(EventTrackInAppClickRequest model);
        Task<ApiResponse<EventTrackResponse>> TrackInAppDeliveryAsync(EventTrackInAppDeliveryRequest model);
        Task<ApiResponse<EventTrackResponse>> TrackInAppCloseAsync(EventTrackInAppCloseRequest model);
        Task<ApiResponse<EventTrackResponse>> InAppConsumeAsync(InAppConsumeRequest model);

    }
}