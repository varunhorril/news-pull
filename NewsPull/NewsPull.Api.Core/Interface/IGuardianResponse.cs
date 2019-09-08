using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Core.Interface
{
    interface IGuardianResponse
    {
        string Status { get; set; }
        string UserTier { get; set; }
        int Total { get; set; }
        int StartIndex { get; set; }
        int Pages { get; set; }
        int PageSize { get; set; }
        int CurrentPage { get; set; }
    }
}
