// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//InMemoryProductManager manager= new InMemoryProductManager(new InMemoryProductDal());
//foreach (var item in manager.getproducts())
//{
//   // Console.WriteLine(item.ProductName);
//}
//EFCORE
int i = 0, y = 0,x=0;
ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var item in productManager.getproducts())
{
    i++;
    Console.WriteLine(i + " " + item.ProductName);
}
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Category id'ye göre sıralama");
Console.WriteLine("---------------------------------------------------------------");

foreach (var item in productManager.getAllByCategory(5))
{
    x++;
    Console.WriteLine(x + " " + item.ProductName);
}
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Min Max değerlere göre list");
Console.WriteLine("---------------------------------------------------------------");

foreach (var item in productManager.getByUnitPrice(50,100))
{
    y++;
    Console.WriteLine(y+ " " + item.ProductName);
}