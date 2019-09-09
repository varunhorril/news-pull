using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuardianNews.Models
{
    public static class ApiMessages
    {

        public const string OK = "OK";
        public const string FAILED = "FAILED";
        public const string SERVER_ERROR = "SERVER_ERROR";

        public const string MISSING_EMAIL = "MISSING_EMAIL";

        public const string MISSING_FREQUENCY = "MISSING_FREQUENCY";
        public const string INVALID_FREQUENCY = "INVALID_FREQUENCY";

        public const string MISSING_TOPIC = "MISSING_TOPIC";
    }
}
