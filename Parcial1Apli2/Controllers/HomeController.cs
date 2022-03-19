using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Parcial1Apli2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1Apli2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Double Monto )
        {
            if (ModelState.IsValid)
            {

                if (Monto % 5 == 0 && Monto != 0)
                {
                    ViewBag.retiro = "Puede retirar su dinero $"+Monto.ToString();
                    return View();
                }
                if (Monto % 5 != 0 && Monto != 0)
                {
                    return RedirectToAction("error", "Home");
                }

            }
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        */
    }

}

