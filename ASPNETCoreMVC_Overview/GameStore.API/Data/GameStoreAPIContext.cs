using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace GameStore.API.Data
{
    public class GameStoreAPIContext : DbContext
    {
        public GameStoreAPIContext (DbContextOptions<GameStoreAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Game { get; set; }
    }
}
