﻿using Armut.Iterable.Client.Contracts;
using Armut.Iterable.Client.Core;
using Armut.Iterable.Client.Core.Responses;
using Armut.Iterable.Client.Models.BrowserModels;
using Armut.Iterable.Client.Models.DeviceModels;
using Armut.Iterable.Client.Models.UserModels;
using System.Threading.Tasks;

namespace Armut.Iterable.Client
{
    public class UserClient : IUserClient
    {
        private readonly IRestClient _client;

        public UserClient(IRestClient client)
        {
            _client = client;
        }

        public async Task<ApiResponse<DeleteUserResponse>> DeleteByEmailAsync(string email)
        {
            Ensure.ArgumentNotNullOrEmptyString(email, nameof(email));

            return await _client.DeleteAsync<DeleteUserResponse>($"/api/users/{email}").ConfigureAwait(false);
        }

        public async Task<ApiResponse<RetrieveUserResponse>> GetByEmailAsync(string email)
        {
            Ensure.ArgumentNotNullOrEmptyString(email, nameof(email));

            return await _client.GetAsync<RetrieveUserResponse>($"/api/users/{email}").ConfigureAwait(false);
        }

        public async Task<ApiResponse<BulkUpdateUserResponse>> BulkUpdateAsync(BulkUpdateUserRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<BulkUpdateUserResponse>("/api/users/bulkUpdate", model.Users).ConfigureAwait(false);
        }

        public async Task<ApiResponse<BulkUpdateSubscriptionsResponse>> BulkUpdateSubscriptionsAsync(BulkUpdateSubscriptionsRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<BulkUpdateSubscriptionsResponse>("/api/users/bulkUpdateSubscriptions", model.UpdateSubscriptionsRequests).ConfigureAwait(false);
        }

        public async Task<ApiResponse<RetrieveUserResponse>> GetByUserIdAsync(string userId)
        {
            Ensure.ArgumentNotNullOrEmptyString(userId, nameof(userId));

            return await _client.GetAsync<RetrieveUserResponse>($"/api/users/byUserId/{userId}").ConfigureAwait(false);
        }

        public async Task<ApiResponse<DeleteUserResponse>> DeleteByUserIdAsync(string userId)
        {
            Ensure.ArgumentNotNullOrEmptyString(userId, nameof(userId));

            return await _client.DeleteAsync<DeleteUserResponse>($"/api/users/byUserId/{userId}").ConfigureAwait(false);
        }

        public async Task<ApiResponse<DisableDeviceResponse>> DisableDeviceAsync(DisableDeviceRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<DisableDeviceResponse>("/api/users/disableDevice", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<RegisterBrowserTokenResponse>> RegisterBrowserTokenAsync(RegisterBrowserTokenRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<RegisterBrowserTokenResponse>("/api/users/registerBrowserToken", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<RegisterDeviceTokenResponse>> RegisterDeviceTokenAsync(RegisterDeviceTokenRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<RegisterDeviceTokenResponse>("/api/users/registerDeviceToken", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<UpdateUserResponse>> UpdateAsync(UpdateUserRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<UpdateUserResponse>("/api/users/update", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<UpdateUserResponse>> UpdateEmailAsync(UpdateEmailRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<UpdateUserResponse>("/api/users/updateEmail", model).ConfigureAwait(false);
        }

        public async Task<ApiResponse<UpdateUserResponse>> UpdateSubscriptionsAsync(UpdateSubscriptionsRequest model)
        {
            Ensure.ArgumentNotNull(model, nameof(model));

            return await _client.PostAsync<UpdateUserResponse>("/api/users/updateSubscriptions", model).ConfigureAwait(false);
        }

    }
}