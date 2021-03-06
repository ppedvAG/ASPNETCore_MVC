using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GameStore.Shared.Entities;
using System.Net.Http;
using Newtonsoft.Json;

namespace GameStore.UI.Pages.Games
{
    public class DetailsModel : PageModel
    {
        string baseAdress = "https://localhost:44347/api/Game/";
        public DetailsModel()
        {

        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            string url = baseAdress + id.ToString();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string jsonText = await response.Content.ReadAsStringAsync();

                Game = JsonConvert.DeserializeObject<Game>(jsonText);
            }

                if (Game == null)
                {
                    return NotFound();
                }
            return Page();
        }
    }
}
