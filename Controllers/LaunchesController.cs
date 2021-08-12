using Microsoft.AspNetCore.Mvc;
using Spacedb.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spacedb.Controllers
{
    public class LaunchesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var launchDetails = await LaunchMethods.GetAllLaunches();
            ViewBag.launchDetails = launchDetails;
            return View();
        }
    }
}
