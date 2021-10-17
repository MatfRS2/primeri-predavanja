using System;
using System.Collections.Generic;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        
        public decimal GenerateTotal()
        {
            throw new NotImplementedException();
        }
    }
}
