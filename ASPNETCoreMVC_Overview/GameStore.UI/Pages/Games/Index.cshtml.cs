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
    public class IndexModel : PageModel
    {
        string baseAdress = "https://localhost:44347/api/Game/";

        public IndexModel()
        {
            
        }

        public IList<Game> Game { get;set; }


        // DELETE      -> URL -> https://locahost:12345/api/Game/3
        // GET (byID)  -> URL -> https://locahost:12345/api/Game/3

        public async Task OnGetAsync()
        {
            HttpClient client = new HttpClient();

            

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, baseAdress);
            HttpResponseMessage response = await client.SendAsync(message);
            string jsonText = await response.Content.ReadAsStringAsync();

            Game = JsonConvert.DeserializeObject<List<Game>>(jsonText);


        }
    }
}
