using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public List<Product> GetInMemory()
        {
            return new List<Product>
            {
                new Product {ProductId=1,ProductName="Elma"},
                new Product {ProductId=3,ProductName="Elma"},
            };
        }
        [HttpGet("ProductList")]

        //public List<Product> GetAllProducts()
        public IActionResult GetAllProducts()

        {
            //   IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.getproducts();
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Product product)
        {
            var result = _productService.AddResult(product);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult Get(int id)
        {
            var result = _productService.GetById(id);
            if (result.IsSuccess == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
