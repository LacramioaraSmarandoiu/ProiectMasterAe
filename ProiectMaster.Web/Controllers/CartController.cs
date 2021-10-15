using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProiectMaster.DataAccess;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMaster.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService productService;

        public CartController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.ShoppingCart);
            var products = productService.GetAllProducts();
            
            return View(products);
        }
        
    }
}
