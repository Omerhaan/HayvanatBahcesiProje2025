using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HayvanatBahcesiProje2025
{
    public partial class Form2 : Form
    {
        SqlConnection baglantı;

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
            Controls.Add(Temalar.AciklamaOlustur("Hayvan bilgilerini goruntuleyin ve bakim saatlerini guncelleyin.", 30, 60, 620));

            dgvHayvanlar.Location = new Point(28, 102);
            dgvHayvanlar.Size = new Size(924, 285);
            Temalar.TabloUygula(dgvHayvanlar);

            label1.Location = new Point(30, 420);
            Temalar.EtiketUygula(label1);
            cmbHayvanlar.Location = new Point(30, 446);
            cmbHayvanlar.Size = new Size(210, 26);
            Temalar.GirisAlaniUygula(cmbHayvanlar);

            label4.Text = "Saglik durumu";
            label4.Location = new Point(270, 420);
            Temalar.EtiketUygula(label4);
            cmbSaglik.Location = new Point(270, 446);
            cmbSaglik.Size = new Size(210, 26);
            Temalar.GirisAlaniUygula(cmbSaglik);

            label2.Location = new Point(510, 420);
            Temalar.EtiketUygula(label2);
            dtpYemek.Location = new Point(510, 446);
            dtpYemek.Size = new Size(130, 26);
            Temalar.GirisAlaniUygula(dtpYemek);

            label3.Text = "Dolasma baslangic";
            label3.Location = new Point(670, 420);
            Temalar.EtiketUygula(label3);
            dtpBaslangic.Location = new Point(670, 446);
            dtpBaslangic.Size = new Size(130, 26);
            Temalar.GirisAlaniUygula(dtpBaslangic);

            label5.Text = "Dolasma bitis";
            label5.Location = new Point(830, 420);
            Temalar.EtiketUygula(label5);
            dtpBitis.Location = new Point(830, 446);
            dtpBitis.Size = new Size(122, 26);
            Temalar.GirisAlaniUygula(dtpBitis);

            btnGuncelle.Text = "Bilgileri Guncelle";
            btnGuncelle.Location = new Point(770, 494);
            btnGuncelle.Size = new Size(182, 40);
            Temalar.BirincilButonUygula(btnGuncelle);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            baglantı = new SqlConnection(Properties.Settings.Default.HayvanatBahcesiVTConnectionString);

            string kayıt = @"SELECT h.hayvan_id,ht.hayvan_tur_ad, h.hayvan_ad, ht.DolasmaBaslangic, ht.yemeksaati, ht.DolasmaBitis,saglik_durumu
                             FROM hayvanlar h
                             JOIN hayvan_turleri ht ON h.hayvan_tur_id = ht.hayvan_tur_id
							 join muayene on h.hayvan_id=muayene.hayvan_id
                             join durumlar d on d.durum_id= muayene.sonuc ";

            SqlDataAdapter da = new SqlDataAdapter(kayıt, baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvHayvanlar.DataSource = dt;

            DataTable dtCombo = dt.Copy();
            cmbHayvanlar.DataSource = dtCombo;
            cmbHayvanlar.DisplayMember = "hayvan_ad";
            cmbHayvanlar.ValueMember = "hayvan_id";

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM durumlar", baglantı);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            cmbSaglik.DataSource = dt2;
            cmbSaglik.DisplayMember = "saglik_durumu";
            cmbSaglik.ValueMember = "durum_id";
        }

        private void cmbHayvanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHayvanlar.SelectedValue == null || cmbHayvanlar.SelectedValue is DataRowView)
                return;

            SqlCommand komut = new SqlCommand(@"
                SELECT ht.yemeksaati, ht.DolasmaBaslangic, ht.DolasmaBitis, h.saglik
                FROM hayvanlar h
                JOIN hayvan_turleri ht ON h.hayvan_tur_id = ht.hayvan_tur_id
                WHERE h.hayvan_id = @id", baglantı);

            komut.Parameters.AddWithValue("@id", cmbHayvanlar.SelectedValue);

            try
            {
                baglantı.Open();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    dtpYemek.Value = DateTime.Today + (TimeSpan)dr["yemeksaati"];
                    dtpBaslangic.Value = DateTime.Today + (TimeSpan)dr["DolasmaBaslangic"];
                    dtpBitis.Value = DateTime.Today + (TimeSpan)dr["DolasmaBitis"];
                    cmbSaglik.SelectedValue = dr["saglik"];
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglantı.State == ConnectionState.Open)
                    baglantı.Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbHayvanlar.SelectedValue == null || cmbHayvanlar.SelectedValue is DataRowView)
                return;

            int hayvanID = Convert.ToInt32(cmbHayvanlar.SelectedValue);

            SqlCommand komut = new SqlCommand(@"
                UPDATE hayvan_turleri 
                SET yemeksaati = @yemek, DolasmaBaslangic = @baslangic, DolasmaBitis = @bitis
                WHERE hayvan_tur_id = (SELECT hayvan_tur_id FROM hayvanlar WHERE hayvan_id = @id);

                UPDATE hayvanlar SET saglik = @saglik WHERE hayvan_id = @id;", baglantı);

            komut.Parameters.AddWithValue("@id", hayvanID);
            komut.Parameters.Add("@yemek", SqlDbType.Time).Value = dtpYemek.Value.TimeOfDay;
            komut.Parameters.Add("@baslangic", SqlDbType.Time).Value = dtpBaslangic.Value.TimeOfDay;
            komut.Parameters.Add("@bitis", SqlDbType.Time).Value = dtpBitis.Value.TimeOfDay;
            komut.Parameters.AddWithValue("@saglik", cmbSaglik.SelectedValue);

            try
            {
                baglantı.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Bilgiler güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglantı.State == ConnectionState.Open)
                    baglantı.Close();
            }
            baglantı.Close();
        }
       
                   
    }

}
