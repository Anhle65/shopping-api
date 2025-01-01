using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace shopping_api.Controllers;
using shopping_api.Models;
using System.ComponentModel;

[ApiController]
[Route("products")]
public class ProductController : ControllerBase
{
    private List<Product> allProducts = new List<Product> {
            new Product 
                {   Id = 1, 
                    Name = "Apple", 
                    Price = 1.5f, 
                    Description = "Constant consume" 
                },
            new Product
                {
                    Id = 2,
                    Name = "Cherry",
                    Price = 5.5f,
                    Description = "Constant consume"
                }
            };
    [HttpGet]
    public ActionResult<List<Product>> GetAll()
    {
        return allProducts;
    }

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        var product = allProducts.FirstOrDefault(p=> p.Id == id);
        if(product == null)
        {
            return NotFound();
        }
        return product;
    }
}
