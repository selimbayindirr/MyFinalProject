
using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, EfNortwindContext>, IProductDal //Sen implement etme ben imzamı atıtorum buradakileri kullan
    {
        public List<ProductDetaiDto> GetProductDetails()
        {
            //JOIN
            using (EfNortwindContext context =new EfNortwindContext())
            {
                var result = from p in
                                 context.Products
                             join c in
                             context.Categories
                        on p.CategoryId equals c.CategoryId
                             select new ProductDetaiDto 
                           { ProductId = p.ProductId, ProductName = p.ProductName,CategoryId=c.CategoryId,CategoryName=c.CategoryName,UnitsInStock=p.UnitsInStock};
                return result.ToList();
            }
        }
    }
}
