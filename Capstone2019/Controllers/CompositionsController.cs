using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Capstone2019.Controllers
{
    public class CompositionsController : Controller
    {
        public IActionResult Compositions()
        {
            ViewData["Message"] = "Your Compositions page.";
            return View();
        }
    }
}