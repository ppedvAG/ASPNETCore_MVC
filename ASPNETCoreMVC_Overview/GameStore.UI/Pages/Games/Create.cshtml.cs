using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GameStore.Shared.Entities;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace GameStore.UI.Pages.Games
{
    public class CreateModel : PageModel
    {

        string baseAdress = "https://localhost:44347/api/Game/";

        public CreateModel()
        {
           
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Game Game { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string json = JsonConvert.SerializeObject(Game);

            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PostAsync(baseAdress, data);

                //200er  Code
                string result = await response.Content.ReadAsStringAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
