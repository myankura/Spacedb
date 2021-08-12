using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Spacedb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Spacedb.BusinessLogic;
using System.Linq;
using System.Threading.Tasks;

namespace Spacedb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var launchDetails = await LaunchMethods.GetUpcomingLaunch();
            ViewBag.launchDetails = launchDetails;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
