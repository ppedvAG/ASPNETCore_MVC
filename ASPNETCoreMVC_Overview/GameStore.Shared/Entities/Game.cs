using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Shared.Entities
{
    
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
    }
}
