using Armut.Iterable.Client.Contracts;
using Armut.Iterable.Client.Core;
using Armut.Iterable.Client.Core.Responses;
using Armut.Iterable.Client.Models.BrowserModels;
using Armut.Iterable.Client.Models.DeviceModels;
using Armut.Iterable.Client.Models.UserModels;
using System.Threading.Tasks;
using Armut.Iterable.Client.Models.InAppModels;
using Armut.Iterable.Client.Models.SubscriptionModels;

namespace Armut.Iterable.Client
{
    public class SubscriptionClient : ISubscriptionClient
    {
        private readonly IRestClient _client;

        public SubscriptionClient(IRestClient client)
        {
            _client = client;
        }

        public async Task<ApiResponse<SubscribeUserResponse>> SubscribeUser(string email, IterableSubscriptionGroup subscriptionGroup, string subscriptionGroupId)
        {
            Ensure.ArgumentNotNullOrEmptyString(email, nameof(email));
            return await _client.GetAsync<SubscribeUserResponse>($"/api/subscriptions/{subscriptionGroup}/{subscriptionGroupId}/user/{email}").ConfigureAwait(false);
        }

    }

    public enum IterableSubscriptionGroup
    {
        EmailList, 
        MessageType, 
        MessageChannel
    }
}