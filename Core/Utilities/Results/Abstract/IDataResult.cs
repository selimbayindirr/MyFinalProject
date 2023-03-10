using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult
    {
        /// <summary>
        /// IResult içerisindeki kodlar aslında burada  . . .  
        /// </summary>
        T Data { get; }
    }
}
