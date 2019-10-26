using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Data;

namespace ShoppingCart.Controllers
{
    public class ProductController : Controller
    {
        ShoppingCartContext db;
        public ProductController(ShoppingCartContext _db)
        {
            this.db = _db;
        }
        public IActionResult Index()
        {
            return View(this.db.Products);
        }
    }
}