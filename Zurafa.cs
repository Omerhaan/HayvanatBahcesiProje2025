using System;

namespace HayvanatBahcesiProje2025
{
    public class Zurafa : Hayvan
    {
        public Zurafa(string ad, TimeSpan dolasmaBas, TimeSpan dolasmaBit, TimeSpan yemekSaati, string saglikDurumu = "Sağlıklı")
            : base(ad, "Zürafa", dolasmaBas, dolasmaBit, yemekSaati, saglikDurumu)
        {
        }

        public override string DavranisGoster(TimeSpan saat)
        {
            TimeSpan yemekBitis = YemekSaati.Add(TimeSpan.FromMinutes(45));
            if (saat >= YemekSaati && saat <= yemekBitis)
                return "Ağaç yaprakları ile besleniyor";

            if (saat >= DolasmaBaslangic && saat <= DolasmaBitis)
                return "Geniş savan alanında geziniyor";

            return "Ağaç gölgesinde dinleniyor";
        }
    }
}
