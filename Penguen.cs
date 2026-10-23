using System;

namespace HayvanatBahcesiProje2025
{
    public class Penguen : Hayvan
    {
        public Penguen(string ad, TimeSpan dolasmaBas, TimeSpan dolasmaBit, TimeSpan yemekSaati, string saglikDurumu = "Sağlıklı")
            : base(ad, "Penguen", dolasmaBas, dolasmaBit, yemekSaati, saglikDurumu)
        {
        }

        public override string DavranisGoster(TimeSpan saat)
        {
            TimeSpan yemekBitis = YemekSaati.Add(TimeSpan.FromMinutes(30));
            if (saat >= YemekSaati && saat <= yemekBitis)
                return "Balık ile besleniyor";

            if (saat >= DolasmaBaslangic && saat <= DolasmaBitis)
                return "Havuzda yüzüyor ve buzda kayıyor";

            return "Buz kütlesinde dinleniyor";
        }
    }
}
