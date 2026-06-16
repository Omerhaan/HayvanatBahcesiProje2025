using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesiProje2025
{
    public class Hayvan
    {
        public string Ad { get; set; }
        public string Tur { get; set; }

        public Hayvan(string ad, string tur)
        {
            Ad = ad;
            Tur = tur;
        }

        public virtual string DavranisGoster(TimeSpan saat)
        {
            return "Dinleniyor";
        }
    }
}
