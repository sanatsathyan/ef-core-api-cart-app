using System;
using core_ef_api_cart_app.Models;

namespace core_ef_api_cart_app.DTO
{
  public class CartProducts: Products {
      public int Quantity { get; set;}
  }
}