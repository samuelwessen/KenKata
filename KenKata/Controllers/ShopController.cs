using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KenKata.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            RedirectToAction("Index", "Shop");
            return View();
        }
    }
}
