using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HayvanatBahcesiProje2025
{
    public partial class Form3 : Form
    {
        private readonly string connectionString = Properties.Settings.Default.HayvanatBahcesiVTConnectionString;
        private Label lblZiyaretciMesaj;

        public Form3()
        {
            InitializeComponent();
            ArayuzuDuzenle();
        }

        private void ArayuzuDuzenle()
        {
            Temalar.FormuUygula(this, "Ziyaretçi Bilgilendirme Ekranı");
            ClientSize = new Size(920, 560);

            Controls.Add(Temalar.BaslikOlustur("Ziyaretçi Bilgilendirme Ekranı", 28, 16, 560));
            Controls.Add(Temalar.AciklamaOlustur("Hayvanların anlık aktivitelerini (beslenme, dolaşma, dinlenme) görüntüleyin.", 30, 52, 650));

            Button btnGeriDon = new Button
            {
                Text = "← Ana Menüye Dön",
                Location = new Point(720, 18),
                Size = new Size(172, 36)
            };
            Temalar.IkincilButonUygula(btnGeriDon);
            btnGeriDon.Click += (s, ev) => this.Close();
            Controls.Add(btnGeriDon);

            dgvHayvanlar.Location = new Point(28, 86);
            dgvHayvanlar.Size = new Size(864, 275);
            Temalar.TabloUygula(dgvHayvanlar);

            // Visitor Information Row
            label1.Text = "Ziyaretçi Adı:";
            label1.Location = new Point(30, 380);
            Temalar.EtiketUygula(label1);

            txtAdSoyad.Location = new Point(30, 406);
            txtAdSoyad.Size = new Size(160, 26);
            Temalar.GirisAlaniUygula(txtAdSoyad);

            label2.Text = "Cinsiyet:";
            label2.Location = new Point(205, 380);
            Temalar.EtiketUygula(label2);

            cmbCinsiyet.Location = new Point(205, 406);
            cmbCinsiyet.Size = new Size(120, 26);
            Temalar.GirisAlaniUygula(cmbCinsiyet);

            Label lblHayvanSecim = Temalar.AciklamaOlustur("Hayvan Seçimi:", 340, 380, 150);
            lblHayvanSecim.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblHayvanSecim.ForeColor = Temalar.Metin;
            Controls.Add(lblHayvanSecim);

            cmbHayvan.Location = new Point(340, 406);
            cmbHayvan.Size = new Size(170, 26);
            Temalar.GirisAlaniUygula(cmbHayvan);

            Label lblTarih = Temalar.AciklamaOlustur("Tarih:", 525, 380, 100);
            lblTarih.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTarih.ForeColor = Temalar.Metin;
            Controls.Add(lblTarih);

            dtpTarih.Location = new Point(525, 406);
            dtpTarih.Size = new Size(140, 26);
            Temalar.GirisAlaniUygula(dtpTarih);

            Label lblSaat = Temalar.AciklamaOlustur("Ziyaret Saati:", 680, 380, 120);
            lblSaat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSaat.ForeColor = Temalar.Metin;
            Controls.Add(lblSaat);

            dtpSaat.Location = new Point(680, 406);
            dtpSaat.Size = new Size(120, 26);
            Temalar.GirisAlaniUygula(dtpSaat);

            // Message bar for visitor feedback
            lblZiyaretciMesaj = new Label
            {
                AutoSize = false,
                Location = new Point(30, 448),
                Size = new Size(864, 24),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Italic),
                ForeColor = Temalar.AnaRenk,
                Visible = false
            };
            Controls.Add(lblZiyaretciMesaj);

            btnListele.Text = "Tüm Hayvanları Listele";
            btnListele.Location = new Point(28, 485);
            btnListele.Size = new Size(200, 40);
            Temalar.IkincilButonUygula(btnListele);

            btnKaydet.Text = "Anlık Aktiviteyi Sorgula";
            btnKaydet.Location = new Point(672, 485);
            btnKaydet.Size = new Size(220, 40);
            Temalar.BirincilButonUygula(btnKaydet);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpSaat.Format = DateTimePickerFormat.Time;
            dtpSaat.ShowUpDown = true;

            HayvanlariYukle();
            AktiviteSorgula();
        }

        private void HayvanlariYukle()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT hayvan_id, RTRIM(hayvan_ad) AS hayvan_ad FROM hayvanlar ORDER BY hayvan_ad";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow allRow = dt.NewRow();
                    allRow["hayvan_id"] = 0;
                    allRow["hayvan_ad"] = "--- Tüm Hayvanlar ---";
                    dt.Rows.InsertAt(allRow, 0);

                    cmbHayvan.DataSource = dt;
                    cmbHayvan.DisplayMember = "hayvan_ad";
                    cmbHayvan.ValueMember = "hayvan_id";
                    cmbHayvan.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvan listesi alınamadı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AktiviteSorgula(bool filtreSeciliHayvan = true)
        {
            TimeSpan secilenSaat = dtpSaat.Value.TimeOfDay;
            int secilenHayvanId = (filtreSeciliHayvan && cmbHayvan.SelectedValue is int) 
                ? (int)cmbHayvan.SelectedValue 
                : 0;

            List<Hayvan> hayvanlar = new List<Hayvan>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        h.hayvan_id,
                        RTRIM(h.hayvan_ad) AS hayvan_ad,
                        RTRIM(ht.hayvan_tur_ad) AS hayvan_tur_ad,
                        ht.DolasmaBaslangic,
                        ht.DolasmaBitis,
                        ht.yemeksaati,
                        d.saglik_durumu
                    FROM hayvanlar h
                    JOIN hayvan_turleri ht ON h.hayvan_tur_id = ht.hayvan_tur_id
                    JOIN durumlar d ON d.durum_id = h.saglik";

                if (secilenHayvanId > 0)
                {
                    query += " WHERE h.hayvan_id = @id";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                if (secilenHayvanId > 0)
                {
                    cmd.Parameters.AddWithValue("@id", secilenHayvanId);
                }

                try
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string ad = dr["hayvan_ad"].ToString();
                            string tur = dr["hayvan_tur_ad"].ToString();
                            TimeSpan dolasmaBas = (TimeSpan)dr["DolasmaBaslangic"];
                            TimeSpan dolasmaBit = (TimeSpan)dr["DolasmaBitis"];
                            TimeSpan yemekSaati = (TimeSpan)dr["yemeksaati"];
                            string saglik = dr["saglik_durumu"].ToString();

                            Hayvan h = HayvanFabrikasi.Olustur(tur, ad, dolasmaBas, dolasmaBit, yemekSaati, saglik);
                            h.Id = Convert.ToInt32(dr["hayvan_id"]);
                            hayvanlar.Add(h);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri sorgulama hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Hayvan Adı");
            dt.Columns.Add("Türü");
            dt.Columns.Add("Sağlık Durumu");
            dt.Columns.Add("Yemek Saati");
            dt.Columns.Add("Dolaşma Saatleri");
            dt.Columns.Add("Seçilen Saatteki Davranış / Durum");

            foreach (var h in hayvanlar)
            {
                string anlikDurum = h.DavranisGoster(secilenSaat);
                string dolasmaAralik = string.Format("{0:hh\\:mm} - {1:hh\\:mm}", h.DolasmaBaslangic, h.DolasmaBitis);
                string yemek = string.Format("{0:hh\\:mm}", h.YemekSaati);

                dt.Rows.Add(h.Ad, h.Tur, h.SaglikDurumu, yemek, dolasmaAralik, anlikDurum);
            }

            dgvHayvanlar.DataSource = dt;

            if (!string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                lblZiyaretciMesaj.Text = string.Format("Sn. {0}, saat {1:hh\\:mm} itibarıyla hayvan aktiviteleri listelenmiştir.",
                    txtAdSoyad.Text.Trim(), secilenSaat);
                lblZiyaretciMesaj.Visible = true;
            }
            else
            {
                lblZiyaretciMesaj.Visible = false;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (cmbHayvan.Items.Count > 0)
                cmbHayvan.SelectedIndex = 0;

            AktiviteSorgula(filtreSeciliHayvan: false);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AktiviteSorgula(filtreSeciliHayvan: true);
        }

        private void dgvHayvanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
