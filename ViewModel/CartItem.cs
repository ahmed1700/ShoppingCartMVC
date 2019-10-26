using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.ViewModel
{
    public class CartItem
    {
        public List<Item> Cart { get; set; }
        public decimal Total { get; set; }
    }
}
