using System.Threading.Tasks;
using Armut.Iterable.Client.Core.Responses;
using Armut.Iterable.Client.Models.BrowserModels;
using Armut.Iterable.Client.Models.DeviceModels;
using Armut.Iterable.Client.Models.InAppModels;
using Armut.Iterable.Client.Models.UserModels;

namespace Armut.Iterable.Client.Contracts
{
    public interface IInAppClient
    {
        Task<ApiResponse<GetMessagesResponse>> GetMessages(string email, string userId, int count,
            IterableMessagePlatform platform, string packageName);
    }
}