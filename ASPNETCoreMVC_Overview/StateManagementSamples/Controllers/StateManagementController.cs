using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StateManagementSamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace StateManagementSamples.Controllers
{

    /// <summary>
    /// ViewData / ViewBag /TempData / Session
    /// </summary>
    public class StateManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewDataSample()
        {
            // Initialsierung Sample1
            ViewData["ID"] = 123;
            ViewData["EmailAdress"] = "KevinW@ppedv.de";
            // Initialsierung Sample2
            ViewData.Add("ABC", 123);

            return View(); //
        }
        public IActionResult ViewDataSecondSample ()
        {
            return View();
        }


        public IActionResult ViewBagSample()
        {
            ViewBag.Vornamen = "Mustermann";
            ViewBag.SchmitzKatze = "Meow";

            return View();
        }

        public IActionResult ViewBagSecondSample()
        {
            return View();
        }


        public IActionResult TempDataSample() // Request 1
        {
            TempData["EmailAdress"] = "KevinW@PPEDV.de";
            TempData["ID"] = 123;

            TempData.Keep(); // Nach dem ersten Zugriff 
            return View();
        }

        public IActionResult TempDataSecondSample()
        {
            
            //Mithilfe von TempDataSample -> TempData.Keep() haben wir noch die Daten vorhanden. (Löschen wurde unterdrückt) 
            return View();
        }

        public IActionResult TempDataThirdSample()
        {
            return View();
        }

        public IActionResult SessionInit()
        {
            HttpContext.Session.SetInt32("Age", 33);
            HttpContext.Session.SetString("Name", "Mustermann");

            Person person1 = new Person() { ID = 123, Vorname = "Max", Nachname = "Mustermann" };

            string jsonString = JsonSerializer.Serialize(person1);
            HttpContext.Session.SetString("PersonObj", jsonString);

            return View();
        }


    }
}
