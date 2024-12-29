using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace shopping_api.Controllers;
using shopping_api.Models;
using System.ComponentModel;

[ApiController]
[Route("products")]
public class ProductController : ControllerBase
{

    [HttpGet]
    public ActionResult<List<Product>> GetAll()
    {
        return new List<Product> {
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
    }

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        var allProducts = new List<Product> {
                            new Product {   
                                Id = 1,
                                Name = "Apple",
                                Price = 1.5f,
                                Description = "Constant consume"
                            },
                            new Product {
                                Id = 2,
                                Name = "Cherry",
                                Price = 5.5f,
                                Description = "Constant consume"
                            }
                            };
        var product = allProducts.FirstOrDefault(p=> p.Id == id);
        if(product == null)
        {
            return NotFound();
        }
        return product;
    }
}
