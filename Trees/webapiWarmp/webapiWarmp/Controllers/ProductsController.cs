using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapiWarmp.Models;

namespace webapiWarmp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] product = new Product[]
        {
            new Product {ID =1, Name="Sharmi", Category="test", Price= 2.95M},
             new Product {ID =1, Name="Sharmi1", Category="test2", Price= 2.75M}
        };

        public IEnumerable<Product> getAllProducts()
        {
            return product;
        }

        public IHttpActionResult GetProduct(int id)
        {

            var products = product.FirstOrDefault((p) => p.ID == id);
            if(product == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(products);
            }
        }


    }
}
