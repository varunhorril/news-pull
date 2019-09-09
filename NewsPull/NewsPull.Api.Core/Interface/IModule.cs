using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Core.Interface
{
    public interface IModule
    {
        IResponse Process();
    }
}
