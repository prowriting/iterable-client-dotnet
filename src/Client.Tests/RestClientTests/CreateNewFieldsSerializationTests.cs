using Armut.Iterable.Client.Core;
using Armut.Iterable.Client.Models.UserModels;
using Moq;
using Moq.Protected;
using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Armut.Iterable.Client.Tests.RestClientTests
{
    public class CreateNewFieldsSerializationTests
    {
        [Fact]
        public async Task Update_Sends_CreateNewFields_When_Set()
        {
            var body = await SendAsync("/api/users/update", new UpdateUserRequest { UserId = "12", CreateNewFields = true });

            Assert.True(body.Value<bool>("createNewFields"));
        }

        [Fact]
        public async Task Update_Omits_CreateNewFields_When_Not_Set()
        {
            var body = await SendAsync("/api/users/update", new UpdateUserRequest { UserId = "12" });

            Assert.Null(body.Property("createNewFields"));
        }

        [Fact]
        public async Task BulkUpdate_Sends_CreateNewFields_At_The_Top_Level_When_Set()
        {
            var body = await SendAsync("/api/users/bulkUpdate", new BulkUpdateUserRequest
            {
                Users = new UserModel[] { new UpdateUserRequest { UserId = "12" } },
                CreateNewFields = true
            });

            Assert.True(body.Value<bool>("createNewFields"));
            Assert.Null(((JObject)body["users"][0]).Property("createNewFields"));
        }

        [Fact]
        public async Task BulkUpdate_Omits_CreateNewFields_When_Not_Set()
        {
            var body = await SendAsync("/api/users/bulkUpdate", new BulkUpdateUserRequest
            {
                Users = new UserModel[] { new UpdateUserRequest { UserId = "12" } }
            });

            Assert.Null(body.Property("createNewFields"));
        }

        private static async Task<JObject> SendAsync(string path, object request)
        {
            string sentBody = null;
            var handler = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            handler
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .Callback<HttpRequestMessage, CancellationToken>((message, _) => sentBody = message.Content.ReadAsStringAsync().Result)
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{\"msg\": \"\",\"code\": \"Success\"}")
                });

            var restClient = new RestClient(new HttpClient(handler.Object) { BaseAddress = new Uri("https://api.iterable.com/") });

            await restClient.PostAsync<UpdateUserResponse>(path, request).ConfigureAwait(false);

            return JObject.Parse(sentBody);
        }
    }
}
