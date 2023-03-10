using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message) //istersen sadece data ve mesaj ver
        {

        }
        public SuccessDataResult(T data) : base(data, true)//istersen sadece data ver 
        {

        }
        public SuccessDataResult(string message) : base(default, true, message)//istersen sadece mesaj ver 
        {

        }
        public SuccessDataResult() : base(default, true)//istersen hibirşey verme
        {

        }
    }
}
