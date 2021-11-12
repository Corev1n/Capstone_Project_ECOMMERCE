using ECommerce_Main.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_Main.Controllers
{
    public class CategoriesController : Controller
    {
        private static List<Category> categories = new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Dress"},
            new Category{CategoryId=2,CategoryName="Accessory"},
            new Category{CategoryId=3,CategoryName="Bag"}
        };
        public IActionResult Index()
        {
            return View(categories);
        }
    }
}
