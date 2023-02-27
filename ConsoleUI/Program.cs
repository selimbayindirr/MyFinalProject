// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;

InMemoryProductManager manager= new InMemoryProductManager(new InMemoryProductDal());
foreach (var item in manager.getproducts())
{
    Console.WriteLine(item.ProductName);
}
