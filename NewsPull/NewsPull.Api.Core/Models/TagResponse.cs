using NewsPull.Api.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Core.Models
{
    public class TagResponse : IGuardianResponse
    {
        public string Status { get; set; }
        public string UserTier { get; set; }
        public int Total { get; set; }
        public int StartIndex { get; set; }
        public int Pages { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
    }
}
