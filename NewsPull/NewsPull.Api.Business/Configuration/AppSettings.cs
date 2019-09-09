using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Business.Configuration
{
    public class AppSettings
    {
        public static string API_Key { get; set; }
        public static string Guardian_Endpoint { get; set; }
        public static string Guardian_SearchEndpoint { get; set; }
    }
}
