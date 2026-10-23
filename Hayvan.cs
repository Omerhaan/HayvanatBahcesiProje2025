using System;

namespace HayvanatBahcesiProje2025
{
    public class Hayvan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public TimeSpan DolasmaBaslangic { get; set; }
        public TimeSpan DolasmaBitis { get; set; }
        public TimeSpan YemekSaati { get; set; }
        public string SaglikDurumu { get; set; }

        public Hayvan(string ad, string tur, TimeSpan dolasmaBas, TimeSpan dolasmaBit, TimeSpan yemekSaati, string saglikDurumu = "Sağlıklı")
        {
            Ad = ad;
            Tur = tur;
            DolasmaBaslangic = dolasmaBas;
            DolasmaBitis = dolasmaBit;
            YemekSaati = yemekSaati;
            SaglikDurumu = saglikDurumu;
        }

        // Base behavior logic for animals
        public virtual string DavranisGoster(TimeSpan saat)
        {
            // Eating window: 30 minutes duration
            TimeSpan yemekBitis = YemekSaati.Add(TimeSpan.FromMinutes(30));
            if (saat >= YemekSaati && saat <= yemekBitis)
                return "Besleniyor";

            if (saat >= DolasmaBaslangic && saat <= DolasmaBitis)
                return "Dolaşıyor";

            return "Dinleniyor";
        }
    }
}
