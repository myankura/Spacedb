using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spacedb.Controllers
{
    public class RocketsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
