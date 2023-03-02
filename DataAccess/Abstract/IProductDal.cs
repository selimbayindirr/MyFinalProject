using Core.DataAccess.Repositories.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product>
    {
        //List<Product> GetAll();
        //void Add(Product product);
        //void Update(Product product);
        //void Delete(Product product);
        //List<Product> GetAllByCategory(int categoryId); 

        ///Product'a özel bir işlem olduğu için dto işlemini buraya yazıyorum..
        ///Dto's
        ///
        List<ProductDetaiDto> GetProductDetails();


    }
}
