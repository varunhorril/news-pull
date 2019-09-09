using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using NewPull.Api.Models;
using NewsPull.Api.Business;
using NewsPull.Api.Business.Modules;

namespace NewPull.Api.Controller
{
    [Route("")]
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("search")]
        public async Task<IHttpActionResult> SearchNews(string query)
        {
            var apiResponse = new ApiResponse()
            {
                Content = ApiMessages.FAILED,
                StatusCode = HttpStatusCode.InternalServerError
            };

            try
            {
                var search = new SearchModule();
                var searchResult = await search.SearchByQuery(query);

            }
            catch (Exception ex)
            {
                apiResponse.Content = ApiMessages.SERVER_ERROR;
            }

            return apiResponse;
        }


    }
}
