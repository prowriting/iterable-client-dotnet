using System;
using Armut.Iterable.Client.Contracts;
using Armut.Iterable.Client.Core;
using Armut.Iterable.Client.Core.Responses;
using Armut.Iterable.Client.Models.BrowserModels;
using Armut.Iterable.Client.Models.DeviceModels;
using Armut.Iterable.Client.Models.UserModels;
using System.Threading.Tasks;
using Armut.Iterable.Client.Models.InAppModels;

namespace Armut.Iterable.Client
{
    public class InAppClient : IInAppClient
    {
        private readonly IRestClient _client;

        public InAppClient(IRestClient client)
        {
            _client = client;
        }

        public async Task<ApiResponse<GetMessagesResponse>> GetMessages(string email, string userId, int count, IterableMessagePlatform platform, string packageName)
        {
            var idSection = !string.IsNullOrEmpty(email)
                ? $"email={Uri.EscapeDataString(email)}"
                : $"userId={Uri.EscapeDataString(userId)}";
            var packageNameUrlFragment = string.IsNullOrEmpty(packageName) ? "" : $"&packageName={Uri.EscapeDataString(packageName)}";
            return await _client.GetAsync<GetMessagesResponse>($"/api/inApp/getMessages?{idSection}&count={count}&platform={platform}&SDKVersion=None{packageNameUrlFragment}").ConfigureAwait(false);
        }

    }

    public enum IterableMessagePlatform
    {
        iOs,
        Android,
        Web
    }
}