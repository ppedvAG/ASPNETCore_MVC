using ASPNETCoreMVC_Overview.Models;
using DICarSample;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC_Overview.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICar _mockCar;

        public HomeController(ILogger<HomeController> logger, ICar myMockCar )
        {
            _logger = logger;
            _mockCar = myMockCar;

            _logger.LogInformation("Zeige HomeController->Index an");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Zeige HomeController->Privacy an");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
