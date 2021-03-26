using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
