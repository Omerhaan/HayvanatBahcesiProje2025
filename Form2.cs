using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HayvanatBahcesiProje2025
{
    public partial class Form2 : Form
    {
        private readonly string connectionString = Properties.Settings.Default.HayvanatBahcesiVTConnectionString;

        public Form2()
        {
            InitializeComponent();
            ArayuzuDuzenle();
        }

        private void ArayuzuDuzenle()
        {
            Temalar.FormuUygula(this, "Admin Paneli");
            ClientSize = new Size(980, 560);

            Controls.Add(Temalar.BaslikOlustur("Admin Paneli", 28, 22, 430));
            Controls.Add(Temalar.AciklamaOlustur("Hayvan bilgilerini görüntüleyin ve bakım saatlerini güncelleyin.", 30, 60, 620));

            Button btnGeriDon = new Button
            {
                Text = "← Ana Menüye Dön",
                Location = new Point(780, 22),
                Size = new Size(172, 36)
            };
            Temalar.IkincilButonUygula(btnGeriDon);
            btnGeriDon.Click += (s, ev) => this.Close();
            Controls.Add(btnGeriDon);

            dgvHayvanlar.Location = new Point(28, 102);
            dgvHayvanlar.Size = new Size(924, 285);
            Temalar.TabloUygula(dgvHayvanlar);

            label1.Text = "Hayvan Seçin";
            label1.Location = new Point(30, 420);
            Temalar.EtiketUygula(label1);
            cmbHayvanlar.Location = new Point(30, 446);
            cmbHayvanlar.Size = new Size(210, 26);
            Temalar.GirisAlaniUygula(cmbHayvanlar);

            label4.Text = "Sağlık Durumu";
            label4.Location = new Point(270, 420);
            Temalar.EtiketUygula(label4);
            cmbSaglik.Location = new Point(270, 446);
            cmbSaglik.Size = new Size(210, 26);
            Temalar.GirisAlaniUygula(cmbSaglik);

            label2.Text = "Yemek Saati";
            label2.Location = new Point(510, 420);
            Temalar.EtiketUygula(label2);
            dtpYemek.Location = new Point(510, 446);
            dtpYemek.Size = new Size(130, 26);
            Temalar.GirisAlaniUygula(dtpYemek);

            label3.Text = "Dolaşma Başlangıç";
            label3.Location = new Point(670, 420);
            Temalar.EtiketUygula(label3);
            dtpBaslangic.Location = new Point(670, 446);
            dtpBaslangic.Size = new Size(130, 26);
            Temalar.GirisAlaniUygula(dtpBaslangic);

            label5.Text = "Dolaşma Bitiş";
            label5.Location = new Point(830, 420);
            Temalar.EtiketUygula(label5);
            dtpBitis.Location = new Point(830, 446);
            dtpBitis.Size = new Size(122, 26);
            Temalar.GirisAlaniUygula(dtpBitis);

            btnGuncelle.Text = "Bilgileri Güncelle";
            btnGuncelle.Location = new Point(770, 494);
            btnGuncelle.Size = new Size(182, 40);
            Temalar.BirincilButonUygula(btnGuncelle);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter daDurumlar = new SqlDataAdapter("SELECT durum_id, saglik_durumu FROM durumlar", conn);
                    DataTable dtDurumlar = new DataTable();
                    daDurumlar.Fill(dtDurumlar);

                    cmbSaglik.DataSource = dtDurumlar;
                    cmbSaglik.DisplayMember = "saglik_durumu";
                    cmbSaglik.ValueMember = "durum_id";
                }

                HayvanlariListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HayvanlariListele()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        h.hayvan_id AS [Hayvan ID],
                        RTRIM(h.hayvan_ad) AS [Hayvan Adı],
                        RTRIM(ht.hayvan_tur_ad) AS [Tür],
                        ht.yemeksaati AS [Yemek Saati],
                        ht.DolasmaBaslangic AS [Dolaşma Başlangıç],
                        ht.DolasmaBitis AS [Dolaşma Bitiş],
                        d.saglik_durumu AS [Sağlık Durumu]
                    FROM hayvanlar h
                    JOIN hayvan_turleri ht ON h.hayvan_tur_id = ht.hayvan_tur_id
                    JOIN durumlar d ON d.durum_id = h.saglik
                    ORDER BY h.hayvan_id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHayvanlar.DataSource = dt;

                int prevSelected = (cmbHayvanlar.SelectedValue != null && cmbHayvanlar.SelectedValue is int)
                    ? (int)cmbHayvanlar.SelectedValue
                    : -1;

                DataTable dtCombo = dt.Copy();
                cmbHayvanlar.SelectedIndexChanged -= cmbHayvanlar_SelectedIndexChanged;
                cmbHayvanlar.DataSource = dtCombo;
                cmbHayvanlar.DisplayMember = "Hayvan Adı";
                cmbHayvanlar.ValueMember = "Hayvan ID";
                cmbHayvanlar.SelectedIndexChanged += cmbHayvanlar_SelectedIndexChanged;

                if (prevSelected != -1)
                {
                    cmbHayvanlar.SelectedValue = prevSelected;
                }
                else if (cmbHayvanlar.Items.Count > 0)
                {
                    cmbHayvanlar.SelectedIndex = 0;
                }

                HayvanDetayYukle();
            }
        }

        private void HayvanDetayYukle()
        {
            if (cmbHayvanlar.SelectedValue == null || cmbHayvanlar.SelectedValue is DataRowView)
                return;

            int animalId = Convert.ToInt32(cmbHayvanlar.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT ht.yemeksaati, ht.DolasmaBaslangic, ht.DolasmaBitis, h.saglik
                    FROM hayvanlar h
                    JOIN hayvan_turleri ht ON h.hayvan_tur_id = ht.hayvan_tur_id
                    WHERE h.hayvan_id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", animalId);

                try
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            dtpYemek.Value = DateTime.Today + (TimeSpan)dr["yemeksaati"];
                            dtpBaslangic.Value = DateTime.Today + (TimeSpan)dr["DolasmaBaslangic"];
                            dtpBitis.Value = DateTime.Today + (TimeSpan)dr["DolasmaBitis"];
                            cmbSaglik.SelectedValue = dr["saglik"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Detay yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbHayvanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            HayvanDetayYukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbHayvanlar.SelectedValue == null || cmbHayvanlar.SelectedValue is DataRowView)
                return;

            int animalId = Convert.ToInt32(cmbHayvanlar.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE hayvan_turleri 
                    SET yemeksaati = @yemek, DolasmaBaslangic = @baslangic, DolasmaBitis = @bitis
                    WHERE hayvan_tur_id = (SELECT hayvan_tur_id FROM hayvanlar WHERE hayvan_id = @id);

                    UPDATE hayvanlar SET saglik = @saglik WHERE hayvan_id = @id;";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", animalId);
                cmd.Parameters.Add("@yemek", SqlDbType.Time).Value = dtpYemek.Value.TimeOfDay;
                cmd.Parameters.Add("@baslangic", SqlDbType.Time).Value = dtpBaslangic.Value.TimeOfDay;
                cmd.Parameters.Add("@bitis", SqlDbType.Time).Value = dtpBitis.Value.TimeOfDay;
                cmd.Parameters.AddWithValue("@saglik", cmbSaglik.SelectedValue);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bilgiler başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HayvanlariListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
