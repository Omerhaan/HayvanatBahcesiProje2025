using System;

namespace HayvanatBahcesiProje2025
{
    public class Maymun : Hayvan
    {
        public Maymun(string ad, TimeSpan dolasmaBas, TimeSpan dolasmaBit, TimeSpan yemekSaati, string saglikDurumu = "Sağlıklı")
            : base(ad, "Maymun", dolasmaBas, dolasmaBit, yemekSaati, saglikDurumu)
        {
        }

        public override string DavranisGoster(TimeSpan saat)
        {
            TimeSpan yemekBitis = YemekSaati.Add(TimeSpan.FromMinutes(30));
            if (saat >= YemekSaati && saat <= yemekBitis)
                return "Meyve ile besleniyor";

            if (saat >= DolasmaBaslangic && saat <= DolasmaBitis)
                return "Ağaçlara tırmanıyor ve oyun oynuyor";

            return "Dalda kestiriyor";
        }
    }
}
