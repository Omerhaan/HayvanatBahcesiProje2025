using System;

namespace HayvanatBahcesiProje2025
{
    public static class HayvanFabrikasi
    {
        public static Hayvan Olustur(string tur, string ad, TimeSpan dolasmaBas, TimeSpan dolasmaBit, TimeSpan yemekSaati, string saglikDurumu)
        {
            string cleanTur = (tur ?? string.Empty).Trim().ToLowerInvariant();

            switch (cleanTur)
            {
                case "aslan":
                    return new Aslan(ad, dolasmaBas, dolasmaBit, yemekSaati, saglikDurumu);
                case "maymun":
                    return new Maymun(ad, dolasmaBas, dolasmaBit, yemekSaati, saglikDurumu);
                case "penguen":
                    return new Penguen(ad, dolasmaBas, dolasmaBit, yemekSaati, saglikDurumu);
                case "zürafa":
                case "zurafa":
                    return new Zurafa(ad, dolasmaBas, dolasmaBit, yemekSaati, saglikDurumu);
                default:
                    return new Hayvan(ad, tur, dolasmaBas, dolasmaBit, yemekSaati, saglikDurumu);
            }
        }
    }
}
