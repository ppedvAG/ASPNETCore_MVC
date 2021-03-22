using ASPNETCoreMVC_Overview.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreMVC_Overview.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult OnGetAnimalPartial()
        {
            IList<Animal> animals = new List<Animal>();
            animals.Add(new Animal { Name = "Hund" });
            animals.Add(new Animal { Name = "Katze" });
            animals.Add(new Animal { Name = "Maus" });

            return new PartialViewResult
            {
                ViewName = "_AnimalPartialView",
                ViewData = new ViewDataDictionary<List<Animal>>(ViewData, animals)
            };
        }
    }
}
