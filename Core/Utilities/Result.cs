using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success) //public Result(bool success) iki paremetre gelirse bunu buradan al dersin
        {
            //this.Success = success;
            //this.Message = message;

            Message = message;
            //  Success = success;
        }
        public Result(bool success)
        {
            //this.Success = success;
            //this.Message = message;

            //   Message = message;
            IsSuccess = success;
        }
        public Result()
        {
        }
        public bool IsSuccess { get; }
        public string Message { get; }
    }
}
