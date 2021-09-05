using Microsoft.AspNetCore.Mvc;
using Spacedb.BusinessLogic;
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
            var allRockets = await RocketMethods.GetAllRockets();
            ViewBag.allRockets = allRockets;
            return View();
        }

        public async Task<IActionResult> Details(string id)
        {
            var selectedRocket = await RocketMethods.GetRocket(id);
            ViewBag.selectedRocket = selectedRocket;
            return View();
        }
    }
}
