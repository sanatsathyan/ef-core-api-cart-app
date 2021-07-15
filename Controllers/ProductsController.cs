using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_ef_api_cart_app.DTO;
using core_ef_api_cart_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace core_ef_api_cart_app.Controllers
{
    [ApiController]
    public class ProductsController : ControllerBase
    {
         private IConfiguration Configuration;
         
        public ProductsController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        [Route("api/cart/{userId}")]
        [HttpGet]
        public JsonResult GetCartProducts(int userId)
        {
            using(var dbContext = new sampledatabaseContext()) {
                List<Products> lstProducts = dbContext.Products.ToList();
                List<CartProducts> lstCartProducts = new List<CartProducts>();
                foreach(Products objProducts in lstProducts) {
                   CartProducts objCartProducts = new CartProducts();
                   objCartProducts.ProductId = objProducts.ProductId;
                   objCartProducts.ProductName = objProducts.ProductName;
                   objCartProducts.ProductImage = objProducts.ProductImage;
                   objCartProducts.Cost = objProducts.Cost;
                   objCartProducts.Quantity = (new Random()).Next(1, 5);
                   lstCartProducts.Add(objCartProducts);
                }
                return new JsonResult(lstCartProducts);
            }            
        }
    }
}
