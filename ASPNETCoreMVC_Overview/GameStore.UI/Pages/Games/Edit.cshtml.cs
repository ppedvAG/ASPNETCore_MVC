using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GameStore.Shared.Entities;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace GameStore.UI.Pages.Games
{
    public class EditModel : PageModel
    {

        string baseAdress = "https://localhost:44347/api/Game/";

        public EditModel()
        {
            
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            

            try
            {
                string url = baseAdress + Game.Id.ToString();

                string json = JsonConvert.SerializeObject(Game);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    var response = client.PutAsync(url, data);
                    string result = await response.Result.Content.ReadAsStringAsync();
                }
            }
            catch (Exception)
            {
                
            }

            return RedirectToPage("./Index");
        }

        
    }
}
