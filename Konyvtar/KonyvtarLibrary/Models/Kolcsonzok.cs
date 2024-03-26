using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarLibrary.Models
{
    public class Kolcsonzok
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public DateTime SzulIdo { get; set; }
        public string SzulName { get;}

        public Kolcsonzok()
        {
        }

        public ICollection<Kolcsonzesek> Kolcsonzesek { get; } = new List<Kolcsonzesek>();

        public Kolcsonzok(string sor)
        {
            var a = sor.Split(";");
            Nev = a[0];
            SzulIdo = DateTime.Parse(a[1]);
        }
    }
}
