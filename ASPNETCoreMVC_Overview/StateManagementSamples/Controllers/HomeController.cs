using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StateManagementSamples.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace StateManagementSamples.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            string Name = HttpContext.Session.GetString("Name");
            int? Alter = HttpContext.Session.GetInt32("Age");

            string jsonString = HttpContext.Session.GetString("PersonObj");

            Person person = JsonSerializer.Deserialize<Person>(jsonString);

            return View();
        }

        public IActionResult TempDataSample()
        {
            string id = TempData["ID"].ToString();

            string email = TempData["EmailAdress"].ToString();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
