using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarLibrary.Models
{
    public class Kolcsonzesek
    {
        public int Id { get; set; }
        public int KolcsonzokId { get; set; }
        public string Iro { get; set; }
        public string Mufaj { get; set; }
        public string Cim { get; set; }

        public ICollection<Kolcsonzok> Kolcsonzok { get; } = new List<Kolcsonzok>();

        public Kolcsonzesek()
        {
        }

        public Kolcsonzesek(string sor)
        {
            var t = sor.Split(';');
            KolcsonzokId = Convert.ToInt32(t[0]);
            Iro = t[1];
            Mufaj = t[2];
            Cim = t[3];
        }
    }
}
