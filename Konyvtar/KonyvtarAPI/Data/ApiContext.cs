using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KonyvtarLibrary.Models;

namespace KonyvtarApiContext.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public ApiContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=KonyvtarNo2.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<KonyvtarLibrary.Models.Kolcsonzesek> Kolcsonzes { get; set; } = default!;

        public DbSet<KonyvtarLibrary.Models.Kolcsonzok>? Kolcsonzo { get; set; }
    }
}
