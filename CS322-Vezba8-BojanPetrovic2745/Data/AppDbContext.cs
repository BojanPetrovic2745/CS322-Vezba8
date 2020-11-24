using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CS322_Vezba8_BojanPetrovic2745.Models;

namespace CS322_Vezba8_BojanPetrovic2745.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CS322_Vezba8_BojanPetrovic2745.Models.Game> Game { get; set; }
    }
}
