using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameStore.Shared.Entities;

namespace GameStore2.API.Data
{
    public class GameStore2APIContext : DbContext
    {
        public GameStore2APIContext (DbContextOptions<GameStore2APIContext> options)
            : base(options)
        {
        }

        public DbSet<GameStore.Shared.Entities.Game> Game { get; set; }
    }
}
