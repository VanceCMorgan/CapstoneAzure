using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Capstone2019.Controllers
{
    public class SongmakerController : Controller
    {
        public IActionResult Songmaker()
        {
            return View();
        }
    }
}