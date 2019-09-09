using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Core.Interface
{
    public interface IResponse
    {
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        object Data { get; set; }
    }
}
