using NewsPull.Api.Business.Configuration;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Business.Helpers
{
    public static class ConfigHelper
    {
        public static string GetDevApiKey()
        {
            try
            {
                return Environment.GetEnvironmentVariable("GUARDIAN_API_KEY");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "[ERROR] API Key not found.");
                throw ex;
            }
        }

    }
}
