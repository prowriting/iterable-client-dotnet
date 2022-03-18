using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Armut.Iterable.Client.Core.Responses;
using Armut.Iterable.Client.Models.InAppModels;
using Armut.Iterable.Client.Models.SubscriptionModels;

namespace Armut.Iterable.Client.Contracts
{
    public interface ISubscriptionClient
    {
        Task<ApiResponse<SubscribeUserResponse>> SubscribeUser(string email, IterableSubscriptionGroup subscriptionGroup,
            string subscriptionGroupId);
    }
}
