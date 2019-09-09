using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace GuardianNews.Models
{
    public class ApiResponse : IActionResult
    {
        public string Content { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public Task ExecuteResultAsync(ActionContext context)
        {
            var httpResponse = new HttpResponseMessage()
            {
                Content = new StringContent(Content, Encoding.UTF8, "application/json"),
                StatusCode = StatusCode
            };

            return Task.FromResult(httpResponse);
        }
    }
}
