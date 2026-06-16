using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvanatBahcesiProje2025
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            ArayuzuDuzenle();
        }

        private void ArayuzuDuzenle()
        {
            Temalar.FormuUygula(this, "Ziyaretci Bilgilendirme Ekrani");
            ClientSize = new Size(920, 540);

            Controls.Add(Temalar.BaslikOlustur("Ziyaretci Bilgilendirme Ekrani", 28, 22, 560));
            Controls.Add(Temalar.AciklamaOlustur("Hayvanlarin dolasma, beslenme ve dinlenme durumlarini goruntuleyin.", 30, 60, 700));

            dgvHayvanlar.Location = new Point(28, 102);
            dgvHayvanlar.Size = new Size(864, 270);
            Temalar.TabloUygula(dgvHayvanlar);

            label1.Location = new Point(30, 404);
            Temalar.EtiketUygula(label1);
            txtAdSoyad.Location = new Point(30, 430);
            txtAdSoyad.Size = new Size(190, 26);
            Temalar.GirisAlaniUygula(txtAdSoyad);

            label2.Location = new Point(250, 404);
            Temalar.EtiketUygula(label2);
            cmbCinsiyet.Location = new Point(250, 430);
            cmbCinsiyet.Size = new Size(150, 26);
            Temalar.GirisAlaniUygula(cmbCinsiyet);

            Controls.Add(Temalar.AciklamaOlustur("Hayvan", 430, 404, 170));
            cmbHayvan.Location = new Point(430, 430);
            cmbHayvan.Size = new Size(170, 26);
            Temalar.GirisAlaniUygula(cmbHayvan);

            Controls.Add(Temalar.AciklamaOlustur("Tarih", 630, 380, 170));
            dtpTarih.Location = new Point(630, 404);
            dtpTarih.Size = new Size(170, 26);
            Temalar.GirisAlaniUygula(dtpTarih);

            Controls.Add(Temalar.AciklamaOlustur("Saat", 630, 416, 170));
            dtpSaat.Location = new Point(630, 440);
            dtpSaat.Size = new Size(170, 26);
            Temalar.GirisAlaniUygula(dtpSaat);

            btnListele.Text = "Hayvanlari Listele";
            btnListele.Location = new Point(28, 478);
            btnListele.Size = new Size(180, 40);
            Temalar.IkincilButonUygula(btnListele);

            btnKaydet.Text = "Durumu Goster";
            btnKaydet.Location = new Point(720, 478);
            btnKaydet.Size = new Size(172, 40);
            Temalar.BirincilButonUygula(btnKaydet);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.HayvanatBahcesiVTConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT hayvan_ad FROM hayvanlar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbHayvan.DataSource = dt;
                cmbHayvan.DisplayMember = "hayvan_ad";
                cmbHayvan.SelectedIndex = -1; // boş başlasın
            }

            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpSaat.Format = DateTimePickerFormat.Time;
            dtpSaat.ShowUpDown = true;
        }

       

        private void btnListele_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarih.Value.Date;
            TimeSpan saat = dtpSaat.Value.TimeOfDay;

            string sorgu = @"
            SELECT h.hayvan_ad,ht.hayvan_tur_ad,ht.DolasmaBaslangic,ht.yemeksaati, ht.DolasmaBitis,
                CASE 
                     WHEN @saat BETWEEN ht.DolasmaBaslangic AND ht.DolasmaBitis THEN 'Dolaşıyor'
                     WHEN @saat = ht.yemeksaati THEN 'Besleniyor'
                ELSE 'Dinleniyor'
             END AS durum
             FROM hayvanlar h
             JOIN hayvan_turleri ht ON h.hayvan_tur_id = ht.hayvan_tur_id";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.HayvanatBahcesiVTConnectionString))
            {
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@saat", saat);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHayvanlar.DataSource = dt;
            }
        }

        private void dgvHayvanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TimeSpan saat = dtpSaat.Value.TimeOfDay;
            List<Hayvan> hayvanListesi = new List<Hayvan>();

            using (SqlConnection baglanti = new SqlConnection(Properties.Settings.Default.HayvanatBahcesiVTConnectionString))
            {
                string sorgu = @"SELECT h.hayvan_ad, ht.DolasmaBaslangic, ht.DolasmaBitis, ht.yemeksaati
                         FROM hayvanlar h
                         JOIN hayvan_turleri ht ON h.hayvan_tur_id = ht.hayvan_tur_id";

                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string ad = dr["hayvan_ad"].ToString();
                    TimeSpan dolasmaBas = (TimeSpan)dr["DolasmaBaslangic"];
                    TimeSpan dolasmaBit = (TimeSpan)dr["DolasmaBitis"];
                    TimeSpan yemekSaati = (TimeSpan)dr["yemeksaati"];

                    
                    hayvanListesi.Add(new Aslan(ad, dolasmaBas, dolasmaBit, yemekSaati));
                }
            }

            
            DataTable dt = new DataTable();
            dt.Columns.Add("Hayvan Adı");
            dt.Columns.Add("Durum");

            foreach (var hayvan in hayvanListesi)
            {
                string durum = hayvan.DavranisGoster(saat); // Polimorfizm
                dt.Rows.Add(hayvan.Ad, durum);
            }

            dgvHayvanlar.DataSource = dt;

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

    }
   
}
