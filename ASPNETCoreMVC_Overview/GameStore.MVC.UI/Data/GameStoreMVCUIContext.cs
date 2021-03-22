using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameStore.Shared.Entities;

namespace GameStore.MVC.UI.Data
{
    public class GameStoreMVCUIContext : DbContext
    {
        public GameStoreMVCUIContext (DbContextOptions<GameStoreMVCUIContext> options)
            : base(options)
        {
        }

        public DbSet<GameStore.Shared.Entities.Game> Game { get; set; }
    }
}
