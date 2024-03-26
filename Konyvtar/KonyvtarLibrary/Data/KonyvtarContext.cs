using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarLibrary.Data
{
    public class KonyvtarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Konyvtar=Library;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<KonyvtarLibrary.Models.Kolcsonzok> Kolcsonzok { get; set; } = default!;

        public DbSet<KonyvtarLibrary.Models.Kolcsonzesek>? Kolcsonzesek { get; set; }
    }
}
