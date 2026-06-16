using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesiProje2025
{
    public class Aslan : Hayvan
    {
        public TimeSpan DolasmaBaslangic { get; set; }
        public TimeSpan DolasmaBitis { get; set; }
        public TimeSpan YemekSaati { get; set; }

        public Aslan(string ad, TimeSpan dolasmaBas, TimeSpan dolasmaBit, TimeSpan yemekSaati)
            : base(ad, "Aslan")
        {
            DolasmaBaslangic = dolasmaBas;
            DolasmaBitis = dolasmaBit;
            YemekSaati = yemekSaati;
        }

        public override string DavranisGoster(TimeSpan saat)
        {
            if (saat >= DolasmaBaslangic && saat <= DolasmaBitis)
                return "Dolaşıyor";
            else if (saat == YemekSaati)
                return "Besleniyor";
            else
                return base.DavranisGoster(saat);
        }
    }
}
