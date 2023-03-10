using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IDataResult<List<Product>> getproducts()
        {
            if (DateTime.Now.Hour == 11)
            {
                return new ErrorDataResult<List<Product>>(
                    
                    Messages.MaintenanceTime);

            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);
        }
        public IDataResult<List<Product>> getAllByCategory(int id)
        {
           return new SuccessDataResult<List<Product>>(
                _productDal.GetAll(p=>p.CategoryId==id));

        }

        public IDataResult<List<Product>> getByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(
             _productDal.GetAll(p=>p.UnitPrice>=min&&p.UnitPrice<=max));
        }

        public IDataResult<List<ProductDetaiDto>> getProductsDtos()
        {

            return new SuccessDataResult<List<ProductDetaiDto>>(_productDal.GetProductDetails());
        }

        public IDataResult<Product> GetById(int productId)
        {
           return new SuccessDataResult<Product>(_productDal.Get(p=>p.ProductId==productId));   
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public IResult AddResult(Product product)
        {
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);

            }
            _productDal.Add(product);
            //result u set etseydin bu şekkilde kullanabilirdin..
            /*Result result =new Result();
            result.Message = "asdasdada";*/
            //veya 
            /*return new Result();*/
            return new SuccessResult(Messages.ProductAdded);
        }
    }
}
