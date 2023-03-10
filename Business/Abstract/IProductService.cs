using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> getproducts();//List<Product>> getproducts(); eski hali
        IDataResult<List<Product>> getAllByCategory(int id);
        IDataResult<List<Product>> getByUnitPrice(decimal min,decimal max);
       IDataResult<List<ProductDetaiDto>> getProductsDtos();

        IDataResult<Product> GetById(int productId);
        void Add(Product product);
        //void olan yerde IRESULT DİYECEĞİZ
        IResult AddResult(Product product);



    }

}
