using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using GuardianNews.Model.ViewModel;
using GuardianNews.Models;
using Microsoft.AspNetCore.Mvc;
using NewsPull.Api.Business.Modules;
using Serilog;

namespace GuardianNews.Controllers
{
    [Route("")]
    public class NewsController : Controller
    {

        [HttpGet]
        [Route("Ping")]
        public IActionResult Ping()
        {
            Log.Information("PING 200 OK");

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

        [HttpPost]
        [Route("subscribe")]
        public IActionResult Subscribe(SubscribeViewModel model)
        {
            var apiResponse = new ApiResponse()
            {
                Content = ApiMessages.FAILED,
                StatusCode = HttpStatusCode.InternalServerError
            };

            try
            {



            }
            catch (Exception ex)
            {
                throw ex;
            }

            return BadRequest();
        }
    }
}