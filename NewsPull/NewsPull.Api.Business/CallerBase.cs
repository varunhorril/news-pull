using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewsPull.Api.Business
{
    public abstract class CallerBase
    {
        private readonly HttpClient _client = new HttpClient();

        protected async Task<T> Execute<T>(string query)
        {
            var response = await _client.GetAsync(query);

            if (!response.IsSuccessStatusCode)
            {
                throw new InvalidOperationException("Error.");
            }

            var obj = JObject.Parse(await response.Content.ReadAsStringAsync());

            return obj["response"].ToObject<T>();
        }
    }
}
