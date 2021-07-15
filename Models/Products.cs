using System;
using System.Collections.Generic;

namespace core_ef_api_cart_app.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal? Cost { get; set; }
    }
}
