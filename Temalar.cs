using System.Drawing;
using System.Windows.Forms;

namespace HayvanatBahcesiProje2025
{
    internal static class Temalar
    {
        public static readonly Color ArkaPlan = Color.FromArgb(244, 246, 248);
        public static readonly Color Yuzey = Color.White;
        public static readonly Color AnaRenk = Color.FromArgb(46, 125, 50);
        public static readonly Color KoyuAnaRenk = Color.FromArgb(27, 94, 32);
        public static readonly Color Metin = Color.FromArgb(38, 50, 56);
        public static readonly Color IkincilMetin = Color.FromArgb(96, 111, 118);
        public static readonly Color Kenarlik = Color.FromArgb(218, 226, 232);
        public static readonly Color AlternatifSatir = Color.FromArgb(248, 250, 251);

        public static void FormuUygula(Form form, string baslik)
        {
            form.Text = baslik;
            form.BackColor = ArkaPlan;
            form.BackgroundImage = null;
            form.BackgroundImageLayout = ImageLayout.None;
            form.ForeColor = Metin;
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimumSize = form.Size;
        }

        public static Panel PanelOlustur(int x, int y, int genislik, int yukseklik)
        {
            return new Panel
            {
                Location = new Point(x, y),
                Size = new Size(genislik, yukseklik),
                BackColor = Yuzey,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        public static Label BaslikOlustur(string metin, int x, int y, int genislik)
        {
            return new Label
            {
                AutoSize = false,
                Text = metin,
                Location = new Point(x, y),
                Size = new Size(genislik, 34),
                Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold),
                ForeColor = Metin,
                BackColor = Color.Transparent
            };
        }

        public static Label AciklamaOlustur(string metin, int x, int y, int genislik)
        {
            return new Label
            {
                AutoSize = false,
                Text = metin,
                Location = new Point(x, y),
                Size = new Size(genislik, 24),
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = IkincilMetin,
                BackColor = Color.Transparent
            };
        }

        public static void BirincilButonUygula(Button buton)
        {
            buton.FlatStyle = FlatStyle.Flat;
            buton.FlatAppearance.BorderSize = 0;
            buton.BackColor = AnaRenk;
            buton.ForeColor = Color.White;
            buton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buton.Height = 40;
            buton.Cursor = Cursors.Hand;
            buton.UseVisualStyleBackColor = false;
        }

        public static void IkincilButonUygula(Button buton)
        {
            buton.FlatStyle = FlatStyle.Flat;
            buton.FlatAppearance.BorderSize = 1;
            buton.FlatAppearance.BorderColor = AnaRenk;
            buton.BackColor = Yuzey;
            buton.ForeColor = KoyuAnaRenk;
            buton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buton.Height = 40;
            buton.Cursor = Cursors.Hand;
            buton.UseVisualStyleBackColor = false;
        }

        public static void GirisAlaniUygula(Control kontrol)
        {
            kontrol.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            kontrol.ForeColor = Metin;
            kontrol.BackColor = Yuzey;
        }

        public static void EtiketUygula(Label etiket)
        {
            etiket.AutoSize = true;
            etiket.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            etiket.ForeColor = Metin;
            etiket.BackColor = Color.Transparent;
        }

        public static void TabloUygula(DataGridView tablo)
        {
            tablo.BackgroundColor = Yuzey;
            tablo.BorderStyle = BorderStyle.None;
            tablo.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tablo.EnableHeadersVisualStyles = false;
            tablo.GridColor = Kenarlik;
            tablo.RowHeadersVisible = false;
            tablo.AllowUserToAddRows = false;
            tablo.AllowUserToDeleteRows = false;
            tablo.ReadOnly = true;
            tablo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablo.MultiSelect = false;
            tablo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablo.ColumnHeadersHeight = 40;
            tablo.RowTemplate.Height = 32;
            tablo.ColumnHeadersDefaultCellStyle.BackColor = KoyuAnaRenk;
            tablo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablo.ColumnHeadersDefaultCellStyle.SelectionBackColor = KoyuAnaRenk;
            tablo.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            tablo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tablo.DefaultCellStyle.BackColor = Yuzey;
            tablo.DefaultCellStyle.ForeColor = Metin;
            tablo.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201);
            tablo.DefaultCellStyle.SelectionForeColor = Metin;
            tablo.AlternatingRowsDefaultCellStyle.BackColor = AlternatifSatir;
        }
    }
}
