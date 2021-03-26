using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Core.Utilities.Results
{
    //Temel void işlemleri için
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
