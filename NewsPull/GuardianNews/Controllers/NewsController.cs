using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using GuardianNews.Models;
using Microsoft.AspNetCore.Mvc;
using NewsPull.Api.Business.Modules;

namespace GuardianNews.Controllers
{
    [Route("")]
    public class NewsController : Controller
    {

        [HttpGet]
        [Route("Ping")]
        public IActionResult Ping()
        {
            return Ok();
        }

        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> SearchNews(string query)
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
                apiResponse.Content = ex.InnerException.ToString();
            }

            return apiResponse;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}