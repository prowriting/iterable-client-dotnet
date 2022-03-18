using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace Armut.Iterable.Client.Core.Responses
{
    public class ApiResponse<TModel> : ApiResponse where TModel : class, new()
    {
        public TModel Model { get; set; }
    }

    public class ApiResponse
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public IDictionary<string, string> Headers { get; set; }

        public string UrlPath { get; set; }

        public string Content { get; set; }

        public bool Error { get; set; }

        public HttpResponseMessage Response { get; set; }

        public string ErrorContent { get; set; }
        public string ErrorRequest { get; set; }
    }
}