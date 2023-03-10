using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Abstract
{
    //Temel Voidler için baslangic
    //void olan yerde IRESULT DİYECEĞİZ

    public interface IResult
    {
        bool IsSuccess { get; } //işlem başarılımı
        string Message { get; } //Mesaj
    }
}
