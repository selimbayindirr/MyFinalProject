// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//InMemoryProductManager manager= new InMemoryProductManager(new InMemoryProductDal());
//foreach (var item in manager.getproducts())
//{
//   // Console.WriteLine(item.ProductName);
//}
//EFCORE
int i = 0, y = 0, x = 0, d = 0;
ProductManager productManager = new ProductManager(new EfProductDal());
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("All Products");
Console.WriteLine("---------------------------------------------------------------");

//i = Allproducts(i, productManager);

x = ProductInCategoryId(x, productManager);

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Min Max değerlere göre list");
Console.WriteLine("---------------------------------------------------------------");

y = ProductPriceMinMaxSearch(y, productManager);

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Category Manager All Category");
Console.WriteLine("---------------------------------------------------------------");
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

d = AllCategories(d, categoryManager);

Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Category Manager GetById");
Console.WriteLine("---------------------------------------------------------------");
//foreach (var item in categoryManager.GetByCategoryId(5))
//{
//    Console.WriteLine(item.CategoryName);
//}
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("DTO's");
Console.WriteLine("---------------------------------------------------------------");

ProductDetailsDTOs(productManager);
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("IRESULT ADDED");
Console.WriteLine("---------------------------------------------------------------");

Product P1 = new Product(5, "test", 100, 100);
productManager.AddResult(P1);






//static int Allproducts(int i, ProductManager productManager)
//{
//    //var result = productManager.getproducts();

//    //if (result.IsSuccess == true)
//    //{
//        foreach (var item in productManager.getproducts())//. data message true false eklenebilri Result konusundan sonra
//        {
//            i++;
//            Console.WriteLine(i + " " + item.ProductName);
//        }

//        return i;
//    //}
//    //else
//    //{
//    //    Console.WriteLine(result.Message);
//    //}

//}
static int ProductInCategoryId(int x, ProductManager productManager)
{
    foreach (var item in productManager.getAllByCategory(5).Data)
    {
        x++;
        Console.WriteLine(x + " " + item.ProductName);
    }

    return x;
}
static int ProductPriceMinMaxSearch(int y, ProductManager productManager)
{
    foreach (var item in productManager.getByUnitPrice(50, 100).Data)
    {
        y++;
        Console.WriteLine(y + " " + item.ProductName);
    }

    return y;
}
static int AllCategories(int d, CategoryManager categoryManager)
{
    foreach (var item in categoryManager.getCategories())
    {
        d++;
        Console.WriteLine(d++ + " " + item.CategoryName);
    }

    return d;
}
static void ProductDetailsDTOs(ProductManager productManager)
{
    var result = productManager.getProductsDtos();

    if (result.IsSuccess == true)
    {
        foreach (var item in productManager.getProductsDtos().Data)
        {
            Console.WriteLine(item.ProductId + "-" + item.ProductName + "-" + item.CategoryId + "-" + item.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}