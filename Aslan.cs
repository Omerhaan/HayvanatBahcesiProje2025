using System;

namespace HayvanatBahcesiProje2025
{
    public class Aslan : Hayvan
    {
        public Aslan(string ad, TimeSpan dolasmaBas, TimeSpan dolasmaBit, TimeSpan yemekSaati, string saglikDurumu = "Sağlıklı")
            : base(ad, "Aslan", dolasmaBas, dolasmaBit, yemekSaati, saglikDurumu)
        {
        }

        public override string DavranisGoster(TimeSpan saat)
        {
            // Lion feeding window: 45 minutes
            TimeSpan yemekBitis = YemekSaati.Add(TimeSpan.FromMinutes(45));
            if (saat >= YemekSaati && saat <= yemekBitis)
                return "Et ile besleniyor (Kükrüyor)";

            if (saat >= DolasmaBaslangic && saat <= DolasmaBitis)
                return "Bölgesinde devriye geziyor";

            return "Gölgede dinleniyor";
        }
    }
}
