using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using NewsPull.Api.Business.Configuration;
using NewsPull.Api.Business.Helpers;
using NewsPull.Api.Core.Interface;
using NewsPull.Api.Core.Models;
using Serilog;

namespace NewsPull.Api.Business.Modules
{
    public class SearchModule : CallerBase
    {
        private string _endpoint;
        private string _apiKey;

        public SearchModule()
        {
            _endpoint = AppSettings.Guardian_SearchEndpoint;
            _apiKey = ConfigHelper.GetDevApiKey();
        }

        public async Task<SearchResponse> SearchByQuery(string query)
        {
            try
            {
                if (IsQueryValid(query))
                {
                    var request = HttpUtility.ParseQueryString(string.Empty);
                    request["q"] = $"\"{query}\"";
                    request["format"] = "json";
                    request["api-key"] = _apiKey;

                    return await Execute<SearchResponse>(_endpoint + $"?{request}");
                }
                else
                {
                    throw new Exception("Query is not valid.");
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "SearchByQuery failed.");
                throw ex;
            }
        }

        private bool IsQueryValid(string query)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                return true;
            }

            return false;
        }
    }
}
