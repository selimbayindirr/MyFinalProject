using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product (1,1,"Bardak",15,15),
                new Product (2,1,"Kamera",500,3),
                new Product (3,2,"Telefon",1500,2),
                new Product (4,2,"Klavye",150,65),
                new Product (5,2,"Mouse",85,1),
            };
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
          return _products;
        }
        public void Update(Product product)
        {
            //Gönderdiğim urun idsine sahip olan urunu bul demek ..
            var productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //ŞUNLARI GÜNCELLE EF İLE DAHA KOLAYLAŞIYOR 
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            //Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //
            throw new NotImplementedException();
        }

    }
}
